using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace nstd
{
    class QueryGenerator
    {
        private static string GenerateSelect(List<Column> cols)
        {

            string columns = cols.Select(x => $"{x.Table}.{x.Name}")
                                 .Aggregate((x, y) => $"{x}, {y}");


            return $"SELECT {columns}";
        }

        private static string GenerateFrom(HashSet<string> tables)
        {
            string from = string.Join(", ", tables);

            return $"\nFROM {from}";
        }

        private static string GenerateWhere(List<Condition> cndtns)
        {
            if (cndtns.Count == 0)
                return "";

            string conditions = cndtns.Select(x => $"{x.Clmn.Table}.{x.Clmn.Name} {x.Criteria} {x.Expression.ToString()} {x.Joint}")
                                    .Aggregate((x, y) => $"{x} {y}");

            return conditions;
        }

        private static string GenerateOrderBy(List<Column> columns, List<string> orders)
        {
            if (columns.Count == 0)
                return "";

            string order = "";

            int i = 0;
            for (; i < columns.Count - 1; i++)
            {
                order += columns[i].Table + "." + columns[i].Name + " " + orders[i] + ", ";
            }
            //i++;
            order += columns[i].Table + "." + columns[i].Name + " " + orders[i];

            return $"\nORDER BY {order}";
        }

        public static string GenerateSQL(List<Column> columns, List<Condition> conditions, List<Column> columnsWithOrder, List<string> orders, List<ForeignKey> keys)
        {
            if (columns.Count == 0)
                return "";

            string where = "";

            var joins = GenerateJoin(columns, conditions, keys);
            string condns = GenerateWhere(conditions);

            if (!(joins.Item2 == "" && condns == ""))
                if (joins.Item2 == "")
                    where = $"\nWHERE ({condns})";
                else
                if (condns == "")
                    where = $"\nWHERE {joins.Item2}";
                else
                    where = $"\nWHERE {joins.Item2} AND ({condns})";

            return GenerateSelect(columns) + joins.Item1 + where + GenerateOrderBy(columnsWithOrder, orders);
        }

        public static NpgsqlCommand GenerateCommand(List<Column> columns, List<Condition> conditions, List<Column> columnsWithOrder, List<string> orders, List<ForeignKey> keys)
        {
            var sCommand = new NpgsqlCommand();

            if (columns.Count == 0)
            {
                sCommand.CommandText = "";
            }
            else
            {
                string where = "";
                var joins = GenerateJoin(columns, conditions, keys);
                if (conditions.Count > 0)
                {
                    string conditionsParam = "";
                    string paramName = "";
                    int i = 1;

                    foreach (Condition condition in conditions)
                    {
                        paramName = "@p" + i.ToString();

                        conditionsParam += $"{condition.Clmn.Table}.{condition.Clmn.Name} {condition.Criteria} {paramName} {condition.Joint} ";

                        sCommand.Parameters.AddWithValue(paramName, condition.Expression);
                        i++;
                    }

                    if (joins.Item2 == "")
                        where = $"\nWHERE ({conditionsParam})";
                    else
                    if (conditionsParam == "")
                        where = $"\nWHERE {joins.Item2}";
                    else
                        where = $"\nWHERE {joins.Item2} AND ({conditionsParam})";
                }
                sCommand.CommandText = GenerateSelect(columns) + joins.Item1 + where + GenerateOrderBy(columnsWithOrder, orders);
            }
            return sCommand;
        }

        private static List<string> Joins(Graph graph, List<string> path)
        {
            List<string> joins = new List<string>();

            string prev = path[0];

            for (int i = 1; i < path.Count; i++)
            {
                joins.Add(Graph.GetPath(graph, prev, path[i]));
                prev = path[i];
            }

            return joins;
        }

        private static (string, string) GenerateJoin(List<Column> columns, List<Condition> conditions, List<ForeignKey> fKeys)
        {
            //string joins = "";
            Graph graph = new Graph(fKeys);

            HashSet<string> tables = new HashSet<string>();
            HashSet<string> allTables = new HashSet<string>();

            foreach (Column column in columns)
            {
                tables.Add(column.Table);
                allTables.Add(column.Table);
            }

            foreach (Condition condition in conditions)
            {
                tables.Add(condition.Clmn.Table);
                allTables.Add(condition.Clmn.Table);
            }

            HashSet<string> allJoins = new HashSet<string>();
            
            foreach (string from in tables)
            {
                foreach (string to in tables)
                {
                    var path = graph.FindPath(graph, from, to);

                    foreach (var t in path)
                    {
                        allTables.Add(t);
                    }

                    var joins = Joins(graph, path);

                    foreach (var join in joins)
                    {
                        allJoins.Add(join);
                    }
                }
            }

            allJoins.Remove("");

            if (allJoins.Count == 0)
            {
                return (GenerateFrom(allTables), "");
            }
            else
            {
                return (GenerateFrom(allTables), "(" + allJoins.Aggregate((x, y) => $"{x} AND {y}") + ")");
            }

        }
    }
}
