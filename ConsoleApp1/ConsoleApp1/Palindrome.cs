using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Palindrome
    {
        // Enter the string
        // 

        public void PalindromeMethod()
        {
            //string sentence = " ";
            string i = "Monday";
            string resultString = "";
            Console.WriteLine("Enter the sentence");
            string userEnteredString = Console.ReadLine();
            string[] Day = new string[i.Length];
            var Day1 = i.ToArray();
            //foreach (var d in Day1)
            //{
            //    Console.WriteLine(d);
            //}

            Console.WriteLine("=====================");

            for (int userinputLength = userEnteredString.Length - 1; userinputLength >= 0; userinputLength--)
            {
                //Console.WriteLine(Day1[a]);
                resultString = resultString + userEnteredString[userinputLength].ToString();
            }
            int tempv;
            for (int k = 0; k < 5; k++)
            {
                k = k + k;
            }

            int[] temparray = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int item in temparray)
            {
                tempv = item + 1;
            }
            //in foreach iterates over a collection,
            //there is no minumum and maximum boundaries we are telling
            //there is no condition checking.
            foreach (var item in userEnteredString)
            {
                Console.WriteLine($"using for each loop\t{item}");
            }

            if (userEnteredString == resultString)
            {
                Console.WriteLine($"You have entered a polindrme {userEnteredString}");
            }
            else
            {
                Console.WriteLine($"You did not entered a polindrome {userEnteredString}");
            }
            //string[] Day2 = new string[i.Length];
            //var Day3 = i.ToArray();
            //Console.WriteLine(Day3);

            //for (int i = 0; i < length; i++)
            //{

            //}
            //Console.WriteLine("Enter the sentence");
            //string UserWord = Console.ReadLine();
            // Madam, DAD, 2552, 1221 , subbu
            //string finalWord = "";
            //MADAM
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("====");
            //for (int j = 5; j >= 1; j--)
            //{
            //    Console.WriteLine(j);
            //}
            //for (int i = 0; i < UserWord.Length; i++)
            //{
            //    Console.WriteLine(UserWord[i].ToString());
            //}

            //if (UserWord == finalWord)
            //{
            //    Console.WriteLine("Polindrome");
            //}
            //else
            //{
            //    Console.WriteLine("not polindrome");
            //}
        }

    }
}
