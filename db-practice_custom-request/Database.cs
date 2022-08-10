using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nstd
{
    class Database
    {
        private static readonly string sConnStr = new NpgsqlConnectionStringBuilder
        {
            Host = Config.Default.Host,
            Port = Config.Default.Port,
            Database = Config.Default.Database,
            Username = Config.Default.Username,
            Password = Config.Default.Password
        }.ConnectionString;

        public static List<Column> AllColumns()
        {
            using (var sConn = new NpgsqlConnection(sConnStr))
            {
                sConn.Open();
                var sCommand = new NpgsqlCommand
                {
                    Connection = sConn,
                    CommandText = @"
                        SELECT table_name, field_name, field_type, transl_fn
                        FROM helpers.fields
                        ORDER BY table_name;"
                };
                using (var reader = sCommand.ExecuteReader())
                {
                    var columns = new List<Column>();
                    while (reader.Read())
                    {
                        var col = new Column((string)reader["field_type"], (string)reader["field_name"], (string)reader["table_name"], (string)reader["transl_fn"]);

                        if (col.Type == "text" || col.Type == "character varying")
                            col.Values = Values(col.Table, col.Name);

                        columns.Add(col);
                    }
                    return columns;
                }
            };
        }

        static List<string> Values(string table, string column)
        {
            List<string> values = new List<string>();
            using (var sConn = new NpgsqlConnection(sConnStr))
            {
                sConn.Open();
                var sCommand = new NpgsqlCommand
                {
                    Connection = sConn,
                    CommandText = $@"
                        SELECT {column}
                        FROM {table}"
                };
                using (var reader = sCommand.ExecuteReader())
                {
                    while(reader.Read())
                        values.Add((string)reader[$"{column}"]);
                }
            }
            return values;
        }

        public static List<ForeignKey> GetForeignKeys()
        {
            using (var sConn = new NpgsqlConnection(sConnStr))
            {
                sConn.Open();
                var sCommand = new NpgsqlCommand
                {
                    Connection = sConn,
                    CommandText = @"
                        SELECT table1, table2, relations
                        FROM helpers.rel_table
                        WHERE via IS NULL;"
                };
                using (var reader = sCommand.ExecuteReader())
                {
                    var fKeys = new List<ForeignKey>();
                    while (reader.Read())
                    {
                        var key = new ForeignKey((string)reader["table1"], (string)reader["table2"], (string)reader["relations"]);
                        fKeys.Add(key);
                    }
                    return fKeys;
                }
            };
        }

        public static void Result(ref DataGridView dgvResult, NpgsqlCommand sCommand, List<Column> columns)
        {
            //if (dgvResult.Rows.Count > 0)
            //    dgvResult.Rows.Clear();
            if (dgvResult.Columns.Count > 0)
                dgvResult.Columns.Clear();

            using (var sConn = new NpgsqlConnection(sConnStr))
            {
                sConn.Open();
                //MessageBox.Show(sCommand.CommandText);
                sCommand.Connection = sConn;

                var res = new DataTable();
                res.Load(sCommand.ExecuteReader());
                dgvResult.DataSource = res;
            }

            int i = 0;
            foreach (Column column in columns)
            {
                dgvResult.Columns[i].HeaderText = column.Alias;
                i++;
            }
        }
    }
}
