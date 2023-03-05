using System;
using DataStructures;
using DataStructuresAndALghorithms.DataStructures;

class Program
{
	static void Main()
	{
		int[] arr = { 7};
		arr = RemoveDublication(arr);

        int n = arr.Length;
		Dictionary<int,List<int>> NumbersPositions = new Dictionary<int,List<int>>();
		for(int i = 0; i < n; i++)
		{
			if (!NumbersPositions.ContainsKey(arr[i]))
				NumbersPositions.Add(arr[i], new List<int>());
			NumbersPositions[arr[i]].Add(i);
        }
		UGraph graph = new UGraph(n);
		for(int i = 0; i < n; i++)
		{
			if(i!=0) graph.AddEdge(i, i - 1);
            if(i!=n-1)graph.AddEdge(i, i + 1);
			
		}
		foreach(int val in NumbersPositions.Keys)
		{
			List<int> list = NumbersPositions[val];
			for(int i=0;i < list.Count; i++)
				for (int j = i; j < list.Count; j++)
					graph.AddEdge(list[i], list[j]);
		}
		Console.WriteLine(graph.ShortestDistanceFrom(0)[n - 1]);
	}

	static int[] RemoveDublication(int[] arr)
	{
		List<int> arr2 = new List<int>();
		arr2.Add(arr[0]);
		for(int i = 1; i < arr.Length; i++)
		{
			if (arr[i] != arr[i - 1]) 
				arr2.Add(arr[i]);
		} 
		return arr2.ToArray();
	}
}