using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Address
    {
        public int HouseNo { get; set; }
        public string streetName { get; set; }
    }

    class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public int PhoneNumber { get; set; }
        public Address personAddress { get; set; }
        private int salary { get; set; }

        public void PrintFullName()

        {
            Console.WriteLine(this.firstName + " " + this.lastName);
        }
        public void Walk()
        {
            Console.WriteLine("I can Wlak");
        }
    }

   
}
