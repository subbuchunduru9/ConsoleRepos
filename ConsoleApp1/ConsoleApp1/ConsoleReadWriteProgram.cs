using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ConsoleReadWriteProgram
    {

        public ConsoleReadWriteProgram()
        {

        }
        public static void ConsoleMethod()
        {
            string saluation = "";
            // Reading & Writing to the Console
            // There are 2 ways Hello UserName
            // + : concatenation (addition)
            // string interpolation or place holder syntax{}
            //Console.WriteLine("Please Enter Your Name");
            //String UserName = Console.ReadLine();
            //Console.WriteLine("Hello " + UserName);


            // Write the program to ask the user for his/her first name, miffle name, last name
            // I want the output as Hello firstname middlename lastname
            // For example: If I enter my firstname: mahesh middlename:Babu lastname: Chunduru
            // I should get the output as: Hello Mahesh Babu Chunduru
            // Members of the class can be property, events or methods all are called members

            Console.WriteLine("Please Enter Your First Name");
            String FirstName = Console.ReadLine();
            Console.WriteLine("Hello {0}", FirstName);

            Console.WriteLine("Please Enter Your Middle Name");
            String MiddleName = Console.ReadLine();
            Console.WriteLine("Hello {0}", MiddleName);

            Console.WriteLine("Please Enter Your Last Name");
            String LastName = Console.ReadLine();
            Console.WriteLine("Hello {0}", LastName);

            Console.WriteLine("Hello " + FirstName + " " + MiddleName + " " + LastName);

            // Using String Interpolation 

            // Scenario: My application should accept the username
            // It should ask his Gender(M/F) M,F,AB
            // It should ask for marital status (M/NTM): Yes/No
            // Output: Hello Mr/Miss username and you are married/not married
            // Lara: Hello {{salutation}} {{username}} and you are not married
            // Bob: Hello {{Username}} you did not told me about your gender and I can not determine your marital staus based on your answer.


            Console.WriteLine("Scenario: My application should accept the username");
            String Username = Console.ReadLine();
            Console.WriteLine(Username);
            String Gender = Console.ReadLine();
            Console.WriteLine("May I know your Gender(M/F)");
            Console.WriteLine("MaritalStatus: No");
            String MaritalStatus = Console.ReadLine();

            if (string.IsNullOrEmpty(Gender) && string.IsNullOrEmpty(MaritalStatus))
            {
                Console.WriteLine("you did not told me about your gender and I can not determine your marital status based on your answer");
            }
            else
            {
                saluation = "[I cannot determine your gender]";
            }
            if (MaritalStatus == "No")
            {
                Console.WriteLine("Output: " + "Hello " + saluation + " " + "and you are not married");
            }
            else if (MaritalStatus == "Yes")
            {
                Console.WriteLine("Output: " + "Hello "  + saluation + " " + Username + " " + " and you are married");
            }
            else
            {
                Console.WriteLine("Output: " + "Hello " + saluation + " " + " " + "I can not determine your marital stauts based on your answer");
            }
        }
    }
}
