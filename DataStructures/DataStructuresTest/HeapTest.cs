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
			int[] nums = { 10,4,2,10};
			int n = nums.Length;
			MaxHeap heap = new MaxHeap(n);
			heap.AddRange(nums);
			Console.WriteLine(heap.ToString());
			while (heap.lastIndex >1)
			{
				int x1 = heap.Pop();
				Console.WriteLine(heap.ToString());
				int x2 = heap.Pop();
				Console.WriteLine(x1);
				Console.WriteLine(x2);
				if(x1!=x2)heap.Add(Math.Abs(x1-x2));
				Console.WriteLine(heap.ToString());
			}

			Console.WriteLine(heap.Peek());
		}
	}
}
