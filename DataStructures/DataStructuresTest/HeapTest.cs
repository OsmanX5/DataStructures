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
			int[] nums = { 1};
			int n = nums.Length;
			MinHeap heap = new MinHeap(n);
			heap.AddRange(nums);
			int res = 0;
			while (heap.Items().Max() != 0)
			{
				int min = heap.Pop();
				while (min == 0)min = heap.Pop();
				heap.Operate(x => x > 0 ? x - min : 0);
				Console.WriteLine(heap.ToString());
				res++;
			}
		}
	}
}
