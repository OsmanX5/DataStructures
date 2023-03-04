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
