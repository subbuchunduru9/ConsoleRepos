using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class OddNumbers
    {
        public void OddNumsUsingWhile()
        {
            int i = 0;
            while (i <= 100)
            {
                Console.Write("\t" + i);
                i = i + 2;
            }
        }

        public void OddNumsUsingDoWhile()
        {
            int i = 1;
            do
            {
                Console.Write("\t" + i);
                i = i + 2;
            } while (i < 100);
            Console.ReadKey();
        }
        public void OddNums()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write("\t" + i); //1
                                         // i = i + 2;
                                         //i= 1+2 =3
                                         //i=3
                                         //i=3+2 =5;

                //i % 2 = 1;
            }
        }
        public void OddNumbersMethod()
        {
            Console.WriteLine("Print the Odd Numbers from 1 to 100");
            //string OddNumbers = Console.ReadLine();
            for (int i = 1; i <= 100; i++)
            {

                //if ((i%2) == 1)
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    //Console.ReadKey();
                }
            }
        }
    }
}
