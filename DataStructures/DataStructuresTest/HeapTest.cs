using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;
using DataStructures.DataStructures;

namespace DataStructuresTest
{
	public class HeapTest
	{
		static HeapTest()
		{
			int n = 5;
			int[][] roads =
			{
				new int[] { 0, 3 },
				new int[] { 2, 4 },
				new int[] { 1, 3 },
				//new int[] { 0, 2 },
				//new int[] { 1, 3 },
				//new int[] { 2, 4 },
			};
			List<int>[] Adj = new List<int>[n];
			for (int i = 0; i < n; i++)Adj[i] = new List<int>();
			foreach (var road in roads)
			{
				int a = road[0];
				int b = road[1];
				Adj[a].Add(b);
				Adj[b].Add(a);
			}
			PrintAdj(Adj);
			int[] importance = new int[n]; //id : score
			MaxHeap<Tuple<int, int>> heap = new MaxHeap<Tuple<int, int>>(n);
			for(int i=0;i<n;i++) heap.Add(new Tuple<int, int>(Adj[i].Count,i));
			Console.WriteLine(heap.ToString());
			for (int i = 0; i < n; i++)
			{
				Tuple<int, int> next = heap.Pop();
				importance[next.Item2] = n - i;
			}
			print(importance);
			int res = 0;
			foreach (var road in roads)
			{
				int a = road[0];
				int b = road[1];
				res += importance[a] + importance[b];
			}
			Console.WriteLine(res);

		}

		static void PrintAdj(List<int>[] adj)
		{
			for (int i = 0; i < adj.Length; i++)
			{
				Console.Write($"{i} : ");
				foreach (var VARIABLE in adj[i]) Console.Write($" {VARIABLE} ");
				Console.WriteLine();
			}
		}
		static void print(int[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write($" [ {i }  {arr[i]} ]");
			}
		}
	}
}
