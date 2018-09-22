using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MultiplicationTable
    {

        public MultiplicationTable()
        {
            Console.WriteLine("Construtor");
        }
        string mathOperator = "";
        long startingNumber = 0;
        long endingNumber = 0;
        long multplicationNumber;
        string operationToExecute = string.Empty;
        long result;
        public void PrintTables()
        {
            try
            {
                //In this try block, You can write any code
                //1.You can validate user enter username and password with the database 
                //this database can be sql server, oracle, mysql, db2, or any other database.
                //2.multiple level user permisson access. example: amazon prime account versus normal account
                //3.if there is any network problem,  we can write the code.
                //database server is down.
                //4.if there is any error occurs, it will go to catch blocks.

                Console.WriteLine("Which table you want to print?:");
                multplicationNumber = long.Parse(Console.ReadLine());

                Console.WriteLine("Print the starting Number");
                startingNumber = long.Parse(Console.ReadLine());

                Console.WriteLine("Print the ending Number");
                endingNumber = long.Parse(Console.ReadLine());

                Console.WriteLine("Enter the operator to perform\nAddition:A\nSubstraction:S\nDivision:D\nMultiplication:M");
                operationToExecute = Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"An error occured while reading the input {ex.Message}");
                Console.Write("Please enter numbers only");
            }
            catch (OverflowException overflowExp)
            {
                Console.WriteLine($"Number is too large {overflowExp.Message}");
                Console.WriteLine($"Don't enter the number more than this {long.MaxValue} number");
            }



            if (this.operationToExecute == "A" || this.operationToExecute == "S" || this.operationToExecute == "M" || this.operationToExecute == "D")
            {

                if (this.operationToExecute == "D")
                {
                    mathOperator = "/";
                }

                if (this.operationToExecute == "A")
                {
                    mathOperator = "+";
                }
                else if (this.operationToExecute == "S")
                {
                    mathOperator = "-";
                }
                else if (this.operationToExecute == "M")
                {
                    mathOperator = "*";
                }
                else
                {
                    mathOperator = "/";
                }
                if (startingNumber < endingNumber || startingNumber <= endingNumber)
                {
                    if (operationToExecute == "")
                    {

                    }
                    for (long i = startingNumber; i <= endingNumber; i++)
                    {
                        switch (mathOperator)
                        {
                            case "+":
                                result = multplicationNumber + i;
                                break;
                            case "/":
                                result = multplicationNumber / i;
                                break;
                            case "*":
                                result = multplicationNumber * i;
                                break;
                            case "-":
                                result = multplicationNumber - i;
                                break;
                            default:
                                break;
                        }
                        Console.WriteLine(multplicationNumber + mathOperator + i + "=" + result);
                    }
                }
                else if (startingNumber > endingNumber)
                {
                    Console.WriteLine("Should be allow only starting number is less than ending number");
                }

            }
            else
            {
                Console.WriteLine("Invalid math operator choice");
            }
            //Console.WriteLine("Which table you want to print?:");
            //multplicationNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine("Print the numbers upto user needs");
            //maximumNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine("5" + "*" + "1" + "=" + 5 * 1);
            //Console.WriteLine("5" + "*" + "2" + "=" + 5 * 2);
            //Console.WriteLine("5" + "*" + "3" + "=" + 5 * 3);
            //Console.WriteLine("5" + "*" + "4" + "=" + 5 * 4);
            //Console.WriteLine("5" + "*" + "5" + "=" + 5 * 5);
            //Console.WriteLine("5" + "*" + "6" + "=" + 5 * 6);
            //Console.WriteLine("5" + "*" + "7" + "=" + 5 * 7);
            //Console.WriteLine("5" + "*" + "8" + "=" + 5 * 8);
            //Console.WriteLine("5" + "*" + "9" + "=" + 5 * 9);
            //Console.WriteLine("5" + "*" + "10" + "=" + 5 * 10);

        }
        //for (int i = 1; i <= 10; i++)
        //{
        //    Console.WriteLine("6" + "*" + i + "=" + 6 * i);
        //}
    }
}

