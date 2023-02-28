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
			int[] nums = { -3,4,3,3};
			int n = nums.Length;
			int k = 2;
			MaxHeap<Tuple<int,int>> heap = new MaxHeap<Tuple<int, int>>(n);
			for (int i = 0; i < n; i++)
			{
				heap.Add(new Tuple<int, int>(nums[i], i));
			}

			Tuple<int, int>[] res = new Tuple<int, int>[k];
			int lastIndex = -1;
			int resI = 0;
			while (heap.Count() > 0)
			{
				if (resI >= k) break;
				var x = heap.Pop();
				int index = x.Item2;
				int val = x.Item1;
				if (index >= lastIndex)
				{
					res[resI] = x;
					resI++;
				}
			}
			int[] res2 = (from x in res orderby x.Item2 select x.Item1).ToArray();
			foreach (var VARIABLE in res2)
			{
				Console.WriteLine(VARIABLE);
			}
		}
	}
}
