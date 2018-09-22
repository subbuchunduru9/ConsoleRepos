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
        int[] studentMarks = new int[10]; //school 
        string[] foodNames = new string[3]; //Hotel
        string[] friendsList = new string[2]; //this will come from the database.
        string[] likes = new string[2];

        public void PrintArrays()
        {
            #region StudentMarks
            //Initialize the vavlues for the arrays
            studentMarks[0] = 45;
            studentMarks[1] = 30;
            studentMarks[2] = 145;
            studentMarks[3] = 340;
            studentMarks[4] = 435;
            studentMarks[5] = 360;
            studentMarks[6] = 455;
            studentMarks[7] = 320;
            studentMarks[8] = 485;
            studentMarks[9] = 310;
            //studentMarks[10] = 660;
            

            //Print the values of the arrays
            //Console.WriteLine(studentMarks.Length);
            //Console.WriteLine("First subject marks:{0}", studentMarks[0]);
            //Console.WriteLine("First subject marks:{0}", studentMarks[1]);
            //Console.WriteLine("First subject marks:{0}", studentMarks[2]);
            //Console.WriteLine("First subject marks:{0}", studentMarks[3]);
            //Console.WriteLine("First subject marks:{0}", studentMarks[4]);
            //Console.WriteLine("First subject marks:{0}", studentMarks[5]);
            //Console.WriteLine("First subject marks:{0}", studentMarks[6]);
            //Console.WriteLine("First subject marks:{0}", studentMarks[7]);
            //Console.WriteLine("First subject marks:{0}", studentMarks[8]);
            //Console.WriteLine("First subject marks:{0}", studentMarks[9]);
            //Console.WriteLine("Second subject marks:{0}{1}", studentMarks[1], studentMarks[0]);

            //Length of the student array
            Console.WriteLine("====================");

            Console.WriteLine(studentMarks.Length);
            #endregion

            #region Console
            Console.WriteLine("====================");
            //simple for loop

            for (int i = 0; i <= 6; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("====================");
           

            #endregion
            #region NewREgion


            //USING FOR LOOP TO PRING THE ARRAY VALUES. 
            for (int i = 0; i < studentMarks.Length; i++)
            {
                Console.WriteLine("Array index position:{0} and array value is:{1}", i, studentMarks[i]);
            }

            Console.WriteLine("====================");

            foodNames[1] = "Rice";

            foodNames[0] = "Chapathi";
            foodNames[0] = "some junk characters";

            foodNames[2] = "Curry";
            foodNames[2] = "#$$#@$#$#%$%#$%$#%#$%$3";
            foodNames[2] = "23432";

            // For loop 


            for (int i = 0; i < foodNames.Length; i++)
            {
                Console.WriteLine("Array index position:{0} and array is:{1}", i, foodNames[i]);
            }



            // Print the values of the arrays
            //Console.WriteLine("(Frist Food Name: {0}", foodNames[0]);
            //Console.WriteLine("Second Food Name: {0}", foodNames[1]);
            //Console.WriteLine("Third Food Name: {0}", foodNames[2]);

            friendsList[0] = "Siva";
            friendsList[1] = "454";
            // Print the values of the arrays
            //Console.WriteLine("First Friend Name: {0}", friendsList[0]);
            //Console.WriteLine("Second Friend Name: {0}", friendsList[1]);
            for (int i = 0; i < friendsList.Length; i++)
            {
                Console.WriteLine("Array index postion:{0} and array is:{1}", i, friendsList[i]);
            }

            likes[0] = "Gopi";
            likes[1] = "Sindhu";
            for (int i = 0; i < likes.Length; i++)
            {
                Console.WriteLine("Array index position:{0} and array is:{0}", i, likes[i]);
            }
            // Print the values of the arrays
            //Console.WriteLine("First Like from Facebook: {0}", likes[0]);
            //Console.WriteLine("Second Like from Facebook: {0}", likes[1]);

            #endregion


        }

    }
}
