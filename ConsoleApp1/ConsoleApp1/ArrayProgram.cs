using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ArrayProgram
    {
        //int i = 150;
        //student marks {english,maths, telugu, science,computers.}
        //computer parts [monitor, keyboard,mouse,external monitor, cpu]
        //Array declaration
        int[] studentMarks = new int[2]; //school 
        string[] foodNames = new string[3]; //Hotel
        string[] friendsList = new string[2]; //this will come from the database.
        string[] likes = new string[2];

        public void PrintArrays()
        {
            //Initialize the vavlues for the arrays
            studentMarks[0] = 45;
            studentMarks[1] = 30;
          
            //Print the values of the arrays
            //Console.WriteLine(studentMarks.Length);
            Console.WriteLine("First subject marks:{0}", studentMarks[0]);
            Console.WriteLine("Second subject marks:{0}{1}", studentMarks[1],studentMarks[0]);

            
            foodNames[0] = "Chapathi";
            foodNames[1] = "Rice";
            foodNames[2] = "Curry";
            // Print the values of the arrays
            Console.WriteLine("Frist Food Name: {0}", foodNames[0]);
            Console.WriteLine("Second Food Name: {0}", foodNames[1]);
            Console.WriteLine("Third Food Name: {0}", foodNames[2]);

            friendsList[0] = "Siva";
            friendsList[1] = "Subbu";
            // Print the values of the arrays
            Console.WriteLine("First Friend Name: {0}", friendsList[0]);
            Console.WriteLine("Second Friend Name: {0}", friendsList[1]);


            likes[0] = "Gopi";
            likes[1] = "Sindhu";
            // Print the values of the arrays
            Console.WriteLine("First Like from Facebook: {0}", likes[0]);
            Console.WriteLine("Second Like from Facebook: {0}", likes[1]);



        }


    }
}
