using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //meaning of static keyword.
            //Now only we will see the objects and classes.
            //class are nothing but blue prints 
            ConsoleApp1.ArrayProgram arrayProgramblue = new ArrayProgram();
            arrayProgramblue.PrintArrays();


            //ConsoleApp1.ArrayProgram secondred = new ArrayProgram();
            //secondred.PrintArrays();


            //Static is used to call the methods, without creating the objects.
            //ConsoleApp1.MathClass.MainMethod();
            //Console.WriteLine("First progoram");


            Console.ReadKey();
        }
    }
}
