using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class MaxHeap
    {
        private int[] maxHeap;
        private int heapSize;
        private int realSize;

        public MaxHeap(int size)
        {
            heapSize = size;
            maxHeap = new int[size + 1];
            maxHeap[0] = size;
        }

        public void Add(int value)
        {
            realSize++;
            if (realSize == heapSize)
            {
                realSize--;
                Console.WriteLine("over flow");
                return;
            }
            maxHeap[realSize] = value;
            int index = realSize;
            int parentIndex = index / 2;
            while (maxHeap[index] > maxHeap[parentIndex] && index > 1)
            {
                (maxHeap[index], maxHeap[parentIndex]) = (maxHeap[parentIndex], maxHeap[index]);
                index = parentIndex;
                parentIndex = index / 2;
            }
        }

        public int Peek() => maxHeap[1];

        public int Pop()
        {
            if (realSize < 1) return int.MinValue;
            int toPop = maxHeap[1];
            maxHeap[1] = maxHeap[realSize];
            realSize--;
            int index = 1;
            while (index < realSize / 2)
            {
                int leftIndex = index * 2;
                int rightIndex = index * 2 + 1;
                if (maxHeap[leftIndex] > maxHeap[index] &&
                    maxHeap[leftIndex] > maxHeap[rightIndex])
                {
                    (maxHeap[leftIndex], maxHeap[index]) = (maxHeap[index], maxHeap[leftIndex]);
                    index = leftIndex;
                }
                else if (maxHeap[rightIndex] > maxHeap[index] &&
                         maxHeap[rightIndex] > maxHeap[leftIndex])
                {
                    (maxHeap[rightIndex], maxHeap[index]) = (maxHeap[index], maxHeap[rightIndex]);
                    index = rightIndex;
                }
                else { break; }
            }

            return toPop;
        }

        public int Size() => realSize;

        public override string ToString()
        {
            string s = "\n [ ";
            foreach (int val in maxHeap)
            {
                s += $" {val} ";
            }

            s += "] \n";
            return s;
        }

    }
}
