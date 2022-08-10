using System.Collections.Generic;

namespace nstd
{
    public class Column
    {
        public Column(string type, string name, string table, string alias)
        {
            Type = type;
            Name = name;
            Table = table;
            Alias = alias;
        }

        public string Type { get; set; }
        public string Name { get; set; }
        public string Table { get; set; }
        public string Alias { get; }

        public List<string> Values { get; set; }

        public override string ToString()
        {
            return Alias;
        }
    }
}