using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MultiDimensionalArray
    {
        static int rows = 2;
        static int cols = 3;

        int[,] i = new int[rows, cols];
        int[,,] j = new int[2, 2, 2];

        //0 1 2 3 X this is wrong
        //0 0 0
        //0 0 0

        public void printMultiArray()
        {
            Console.WriteLine("Before assiging the values====================");
            Console.WriteLine(i[0, 0] + " " + i[0, 1] + " " + i[0, 2]);
            Console.WriteLine(i[1, 0] + " " + i[1, 1] + " " + i[1, 2]);

            Console.WriteLine("After assiging the values====================");
            i[0, 0] = 12;
            i[0, 1] = 15;
            i[0, 2] = 16;

            i[1, 0] = 20;
            i[1, 1] = 25;
            i[1, 2] = 30;

            Console.WriteLine(i[0, 0] + " " + i[0, 1] + " " + i[0, 2]);
            Console.WriteLine(i[1, 0] + " " + i[1, 1] + " " + i[1, 2]);

        }



    }
}
