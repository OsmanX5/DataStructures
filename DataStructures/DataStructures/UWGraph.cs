using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class UWGraph
    {
        public Dictionary<int,List<Edge>> adjList;
        public int n;
        public UWGraph(int _n)
        {
            n = _n;
            adjList = new Dictionary<int, List<Edge>>();

        }
        public void AddEdges(IEnumerable<int[]> edges) { 
            foreach (var edge in edges)
            {
                int a = edge[0];
                int b = edge[1];
                int w = edge[2];
                AddEdge(a, b, w);
            }
        }
        public void AddEdge(int a,int b, int w)
        {
            if(!adjList.ContainsKey(a))
                adjList.Add(a, new List<Edge>());
            if(!adjList.ContainsKey(b))
                adjList.Add(b, new List<Edge>());
            adjList[a].Add(new Edge(a, b , w));
            adjList[b].Add(new Edge(b, a , w ));
        }
        public override string ToString()
        {
            string s = "";
            foreach(var node in adjList)
            {
                s += node.Key.ToString() + " : ";
                foreach(var edge in node.Value)
                {
                    s += edge.ToString();
                }
                s += "\n";
            }
            return s;
        }
    
    }
    class Edge{
        public int From, To, Weight;
        public Edge(int a, int b, int w)
        {
            this.From = a;
            this.To = b;
            this.Weight = w;
        }
        public override string ToString()
        {
            return $" ({From}=={Weight}==>{To}) ";
        }
    }
}
