using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndALghorithms.DataStructures
{
    public class UGraph
    {
        public Dictionary<int, HashSet<int>> adjList;
        public int n;
        public UGraph(int _n)
        {
            n = _n;
            adjList = new Dictionary<int, HashSet<int>>();

        }
        public void AddEdges(IEnumerable<int[]> edges)
        {
            foreach (var edge in edges)
            {
                int a = edge[0];
                int b = edge[1];
                AddEdge(a, b);
            }
        }
        public void AddEdge(int a, int b)
        {
            if (!adjList.ContainsKey(a))
                adjList.Add(a, new HashSet<int>());
            if (!adjList.ContainsKey(b))
                adjList.Add(b, new HashSet<int>());
            adjList[a].Add(b);
            adjList[b].Add(a);
        }
        public Dictionary<int, int> ShortestDistanceFrom(int start)
        {
            Dictionary<int, int> Distance = new Dictionary<int, int>();
            Dictionary<int, bool> Visited = new Dictionary<int, bool>();
            foreach(var node in adjList.Keys)
            {
                Distance.Add(node, int.MaxValue);
                Visited.Add(node, false);
            }
            Queue<int> BFS = new Queue<int>();
            BFS.Enqueue(start);
            Distance[start] = 0;
            while(BFS.Count > 0)
            {
                int a = BFS.Dequeue();
                if (Visited[a]) continue;
                Visited[a] = true;
                foreach (int next in adjList[a])
                {
                    Distance[next] = Math.Min(Distance[a]+1, Distance[next] );
                    BFS.Enqueue(next);
                }
            }
            return Distance;
        }
        public override string ToString()
        {
            string s = "";
            foreach (var node in adjList)
            {
                s += node.Key.ToString() + " : ";
                foreach (var edge in node.Value)
                {
                    s += edge.ToString();
                }
                s += "\n";
            }
            return s;
        }

    }
}
