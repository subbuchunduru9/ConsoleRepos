using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MultiplicationTable
    {
        int multplicationNumber = 0;
        int maximumNumber = 0;

        public void PrintTables(int numerToPrint, int maxNumber,string operationToPerform)
        {
            this.multplicationNumber = numerToPrint;
            this.maximumNumber = maxNumber;
            //Console.WriteLine("Which table you want to print?:");
            //multplicationNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine("Print the numbers upto user needs");
            //maximumNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine("2" + "*" + "1" + "=" + 2 * 1);
            //Console.WriteLine("2" + "*" + "2" + "=" + 2 * 2);
            //Console.WriteLine("2" + "*" + "3" + "=" + 2 * 3);
            //Console.WriteLine("2" + "*" + "4" + "=" + 2 * 4);
            //Console.WriteLine("2" + "*" + "5" + "=" + 2 * 5);
            //Console.WriteLine("2" + "*" + "6" + "=" + 2 * 6);
            //Console.WriteLine("2" + "*" + "7" + "=" + 2 * 7);
            //Console.WriteLine("2" + "*" + "8" + "=" + 2 * 8);
            //Console.WriteLine("2" + "*" + "9" + "=" + 2 * 9);
            //Console.WriteLine("2" + "*" + "10" + "=" + 2 * 10);

            for (int i = 1; i <= maximumNumber; i++)
            {
                Console.WriteLine(multplicationNumber + "-" + i + "=" + (multplicationNumber - i));
            }
        }
    }
}
