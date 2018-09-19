using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Factorial
    {
        public void FactorialusingWhile()
        {
            int result = 1;
            Console.WriteLine("Enter the number you want to print");
            int UserInput = int.Parse(Console.ReadLine());
            while (UserInput != 1)
            {
                result = result * UserInput;
                UserInput = UserInput - 1;
            }
            Console.WriteLine(result);
        }

        public void FactorialusingdoWhile()
        {

        }

        public void FactorialMethod()
        {
            int result = 1;
            Console.WriteLine("Enter the Factorial Number you want");
            int UserInput = int.Parse(Console.ReadLine());

            for (int i = 1; i <= UserInput; i++)
            {
                result = result * i;
                //1st loop
                //1=1*1; result = 1;
                //2nd loop
                //1=1*2; reuslt = 2;
                //3rd loop
                //2=2*3; result = 6;
                //4th loop
                //6=6*4; result = 24;
                //5th loop;
                //24=24*5; result = 120;
            }
            Console.WriteLine(result);
        }
    }
}
