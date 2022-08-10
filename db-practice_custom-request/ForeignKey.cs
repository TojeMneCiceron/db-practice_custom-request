using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nstd
{
    internal class ForeignKey
    {
        public ForeignKey(string from, string to, string path)
        {
            From = from;
            To = to;
            Path = path;
        }

        public string From { get; set; }
        public string To { get; set; }
        public string Path { get; set; }
    }

    class Graph
    {
        public Graph(List<ForeignKey> keys)
        {
            Keys = keys;
        }

        public List<ForeignKey> Keys { get; set; }

        public static List<string> FindNeighbours(Graph graph, string table)
        {
            List<string> neighbours = new List<string>();

            foreach (var key in graph.Keys)
            {
                if (key.From == table)
                    neighbours.Add(key.To);
                if (key.To == table)
                    neighbours.Add(key.From);
            }
            return neighbours;
        }

        public static string GetPath(Graph graph, string t1, string t2)
        {
            foreach (var key in graph.Keys)
                if (key.From == t1 && key.To == t2 || key.To == t1 && key.From == t2)
                    return key.Path;
            return "";
        }

        public List<string> FindPath(Graph graph, string from, string to)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue(from);

            HashSet<string> used = new HashSet<string>();
            used.Add(from);

            Dictionary<string, string> prev = new Dictionary<string, string>();
            prev[from] = "";

            while (queue.Count != 0)
            {
                string curTable = queue.Dequeue();
                if (curTable == to)
                    break;

                foreach (string neighbour in FindNeighbours(graph, curTable))
                {
                    if (!used.Contains(neighbour))
                    {
                        queue.Enqueue(neighbour);
                        used.Add(neighbour);
                        prev[neighbour] = curTable;
                    }
                }
            }

            List<string> res = new List<string>();

            string t = to;
            res.Add(t);

            while (prev.ContainsKey(t) && prev[t] != "")
            {
                t = prev[t];
                res.Add(t);
            }

            res.Add(from);
            res.Reverse();

            return res;
        }
    }
}