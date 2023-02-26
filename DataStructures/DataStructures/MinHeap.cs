using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.DataStructures
{
    public class MinHeap
    {
        private int[] minHeap;
        private int Capacity;
        private int realSize;

        public MinHeap(int size)
        {
            Capacity = size;
            minHeap = new int[size + 1];
            minHeap[0] = size;
        }

        public void Add(int value)
        {
            realSize++;
            if (realSize == Capacity)
            {
                realSize--;
                Console.WriteLine("over flow");
                return;
            }
            minHeap[realSize] = value;
            int index = realSize;
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
            if (realSize < 1) return int.MinValue;
            int toPop = minHeap[1];
            minHeap[1] = minHeap[realSize];
            realSize--;
            int index = 1;
            while (index < realSize / 2)
            {
                int leftIndex = index * 2;
                int rightIndex = index * 2 + 1;
                if (minHeap[leftIndex] < minHeap[index] &&
                    minHeap[leftIndex] < minHeap[rightIndex])
                {
                    (minHeap[leftIndex], minHeap[index]) = (minHeap[index], minHeap[leftIndex]);
                    index = leftIndex;
                }
                else if (minHeap[rightIndex] < minHeap[index] &&
                         minHeap[rightIndex] < minHeap[leftIndex])
                {
                    (minHeap[rightIndex], minHeap[index]) = (minHeap[index], minHeap[rightIndex]);
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
            foreach (int val in minHeap)
            {
                s += $" {val} ";
            }

            s += "] \n";
            return s;
        }

    }
}
