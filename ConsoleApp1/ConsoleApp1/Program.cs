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
            int numertoPrint = 9;
            int maxNumber = 4;

            Console.WriteLine("Which table you want to print?:");
            numertoPrint = int.Parse(Console.ReadLine());

            Console.WriteLine("Print the numbers upto user needs");
            maxNumber = int.Parse(Console.ReadLine());

            MultiplicationTable mt = new MultiplicationTable();
            mt.PrintTables(numertoPrint, maxNumber,"S");

            //ConsoleApp1.MathClass.MathMethod();
            //ConsoleApp1.ConsoleReadWriteProgram.ConsoleMethod();
            //MultiDimensionalArray obj = new MultiDimensionalArray();
            //obj.printMultiArray();
            //ConsoleApp1.Person.

            //Person subbu = new Person();
            //subbu.firstName = "subbu";
            //subbu.lastName = "Chunduru";

            //subbu.age = 10;
            //subbu.personAddress.HouseNo = 15;
            //subbu.personAddress.streetName = "somestreet";
            //subbu.PrintFullName();

            //meaning of static keyword.
            //Now only we will see the objects and classes.
            //class are nothing but blue prints 
            //ConsoleApp1.ArrayProgram arrayProgramblue = new ArrayProgram();
            //arrayProgramblue.PrintArrays();


            //ConsoleApp1.ArrayProgram secondred = new ArrayProgram();
            //secondred.PrintArrays();


            //Static is used to call the methods, without creating the objects.
            //ConsoleApp1.MathClass.MainMethod();
            //Console.WriteLine("First progoram");


            Console.ReadKey();
        }
    }
}
