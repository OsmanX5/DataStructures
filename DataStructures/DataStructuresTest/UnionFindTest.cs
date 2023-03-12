using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;

namespace DataStructuresTest
{
    class UnionFindTest
    {
        public UnionFindTest()
        {
            UnionFind disJointSet = new UnionFind(6);
            Console.WriteLine(disJointSet.ToString());
            Console.WriteLine("Conecting 0 and 1");
            disJointSet.Union(0, 1);
            Console.WriteLine(disJointSet.ToString());
            Console.WriteLine("Conecting 1 and 5");
            disJointSet.Union(5, 1);
            Console.WriteLine(disJointSet.ToString());
            Console.WriteLine("Conecting 4 and 2");
            disJointSet.Union(2, 4);
            Console.WriteLine(disJointSet.ToString());
            Console.WriteLine("Conecting 1 and 2");
            disJointSet.Union(2, 1);
            Console.WriteLine(disJointSet.ToString());
            Console.WriteLine("Conecting 0 and 5");
            disJointSet.Union(5, 0);
            Console.WriteLine(disJointSet.ToString());
            Console.WriteLine("Conecting 3 and 4");
            disJointSet.Union(4, 3);
            Console.WriteLine(disJointSet.ToString());
        }
    }
}
