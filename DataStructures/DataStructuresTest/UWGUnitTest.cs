using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataStructuresTest
{
    public class UWGUnitTest
    {
        public  UWGUnitTest()
        {
            int n = 5;
            int[][] edges = new int[][]
            {
                new int[]{0,1,1},
                new int[]{0,2,2},
                new int[]{0,3,3},
                new int[]{0,4,4},
                new int[]{1,2,5},
                new int[]{1,3,6},
                new int[]{1,4,7},
                new int[]{2,3,8},
                new int[]{2,4,9},
                new int[]{3,4,10}
            };
            UWGraph g = new UWGraph(n);
            g.AddEdges(edges);
            Console.WriteLine(g.ToString());
        }
    }
}
