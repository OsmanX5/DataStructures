using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class MinHeap
    {
	    public int[] minHeap;
	    public int Capacity;
	    public int lastIndex;

        public MinHeap(int size)
        {
            Capacity = size+1;
            lastIndex = 0;
            minHeap = new int[Capacity];
        }

        public int[] Items()
        {
            if(lastIndex>0)
				return minHeap[1..(lastIndex+1)];
            return null;
        }

        public void Add(int value)
        {
            lastIndex++;

            if (lastIndex >= Capacity)
            {
                lastIndex--;
                Console.WriteLine("over flow");
                return;
            }
            minHeap[lastIndex] = value;
            int index = lastIndex;
            int parentIndex = index / 2;
            while (minHeap[index] < minHeap[parentIndex] && index > 1)
            {
                (minHeap[index], minHeap[parentIndex]) = (minHeap[parentIndex], minHeap[index]);
                index = parentIndex;
                parentIndex = index / 2;
            }
            
        }

        public void AddRange(IEnumerable arr)
        {
            foreach (int x in arr)
            {
                Add(x);
            }
        }
        public int Peek() => minHeap[1];

        public int Pop()
        {
            if (lastIndex < 1) return int.MinValue;
            int toPop = minHeap[1];
            minHeap[1] = minHeap[lastIndex];
            lastIndex--;
            int index = 1;
            while (index <= lastIndex / 2)
            {
                int leftIndex = index * 2;
                int rightIndex = index * 2 + 1;
                if (minHeap[index] > minHeap[leftIndex] || minHeap[index] > minHeap[rightIndex])
                {
	                if (minHeap[leftIndex] < minHeap[rightIndex])
	                {
		                (minHeap[leftIndex], minHeap[index]) = (minHeap[index], minHeap[leftIndex]);
		                index = leftIndex;
	                }
	                else
	                {
		                (minHeap[rightIndex], minHeap[index]) = (minHeap[index], minHeap[rightIndex]);
		                index = rightIndex;
					}
				}
                else { break; }
            }


			return toPop;
        }

        public int Size() => lastIndex;

        public override string ToString()
        {
            string s = "\n [ ";
            for (int i = 1; i <= lastIndex; i++)
            {
	            s += $" {minHeap[i]} ";
            }

            s += "] \n";
            return s;
        }
        

        public void Operate(Func<int,int> opFunc)
        {
	        for (int i = 1; i <= lastIndex; i++)
	        {
		        minHeap[i] = opFunc(minHeap[i]);
	        }
        }

        
    }
}
