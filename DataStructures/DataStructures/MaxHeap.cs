using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class MaxHeap <T> where T : IComparable
	{
		public T[] maxHeap;
        public int Capasity;
        public int lastIndex;

        public MaxHeap(int size)
        {
            Capasity = size+1;
            maxHeap = new T[Capasity];
            lastIndex = 0;
        }
        public T[] Items()
        {
	        if (lastIndex > 0)
		        return maxHeap[1..(lastIndex + 1)];
	        return null;
        }
		public void Add(T value)
        {
            lastIndex++;
            if (lastIndex >= Capasity)
            {
                lastIndex--;
                Console.WriteLine("over flow");
                return;
            }
            maxHeap[lastIndex] = value;
            int index = lastIndex;
            int parentIndex = index / 2;
            while (maxHeap[index].CompareTo(maxHeap[parentIndex]) >0  && index > 1)
            {
                (maxHeap[index], maxHeap[parentIndex]) = (maxHeap[parentIndex], maxHeap[index]);
                index = parentIndex;
                parentIndex = index / 2;
            }
        }
		public void AddRange(IEnumerable arr)
		{
			foreach (T x in arr)
			{
				Add(x);
			}
		}
		public T Peek() => maxHeap[1];

        public T Pop()
        {
            if (lastIndex < 1) return maxHeap[0];
            T toPop = maxHeap[1];
            maxHeap[1] = maxHeap[lastIndex];
            lastIndex--;
            int index = 1;
            while (index <= lastIndex / 2)
            {
                int leftIndex = index * 2;
                int rightIndex = index * 2 + 1;
                if (maxHeap[index].CompareTo(maxHeap[leftIndex]) < 0
                    || maxHeap[index].CompareTo(maxHeap[rightIndex]) < 0)
                {
	                if (maxHeap[leftIndex].CompareTo(maxHeap[rightIndex]) >0 )
	                {
		                (maxHeap[leftIndex], maxHeap[index]) = (maxHeap[index], maxHeap[leftIndex]);
		                index = leftIndex;
	                }
	                else
	                {
		                (maxHeap[rightIndex], maxHeap[index]) = (maxHeap[index], maxHeap[rightIndex]);
		                index = rightIndex;
	                }
                }
                else { break; }
			}

            return toPop;
        }

        public int Count() => lastIndex;


        public override string ToString()
        {
	        string s = "\n [ ";
	        for (int i = 1; i <= lastIndex; i++)
	        {
		        s += $" {maxHeap[i]} ";
	        }

	        s += "] \n";
	        return s;
        }

	}
}
