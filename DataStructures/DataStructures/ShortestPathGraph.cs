using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndALghorithms.DataStructures
{
    public class ShortestPathGraph
    {
        UWGraph graph;
        public ShortestPathGraph(int n)
        {
            graph = new UWGraph(n);
        }
        Dictionary<int, int> GetShortestPathes(int start)
        {
            Dictionary<int,int> distances = new Dictionary<int, int> ();
            Dictionary<int,bool> Visited = new Dictionary<int,bool> ();
            foreach(int node in graph.adjList.Keys)
            {
                distances[node] = int.MaxValue;
                Visited[node] = false;
            }  
            PriorityQueue<Edge,int> priorityQueue = new PriorityQueue<Edge,int>();
            distances[start] = 0;
            priorityQueue.Enqueue(new Edge(start, start, 0), 1);
            while(priorityQueue.Count > 0)
            {
                Edge CurrentEdge = priorityQueue.Dequeue();
                Visited[CurrentEdge.To] = true;
                distances[CurrentEdge.To] = Math.Min(distances[CurrentEdge.To] 
                    , distances[CurrentEdge.From] + CurrentEdge.Weight);
                foreach(Edge nextEdge in graph.adjList[CurrentEdge.To])
                {
                    if (Visited[nextEdge.To]) continue;
                    priorityQueue.Enqueue(nextEdge, -nextEdge.Weight);
                }
            }
            return distances;
        }
        
    }
}
