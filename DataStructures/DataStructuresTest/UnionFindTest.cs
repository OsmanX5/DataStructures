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
            disJointSet.union(0, 1);
            Console.WriteLine(disJointSet.ToString());
            Console.WriteLine("Conecting 1 and 5");
            disJointSet.union(5, 1);
            Console.WriteLine(disJointSet.ToString());
            Console.WriteLine("Conecting 4 and 2");
            disJointSet.union(2, 4);
            Console.WriteLine(disJointSet.ToString());
            Console.WriteLine("Conecting 1 and 2");
            disJointSet.union(2, 1);
            Console.WriteLine(disJointSet.ToString());
            Console.WriteLine("Conecting 0 and 5");
            disJointSet.union(5, 0);
            Console.WriteLine(disJointSet.ToString());
            Console.WriteLine("Conecting 3 and 4");
            disJointSet.union(4, 3);
            Console.WriteLine(disJointSet.ToString());
        }
    }
}
