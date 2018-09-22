using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Vowels
    {
        public void VowelsMethod()
        {
            int total = 0;
            Console.WriteLine("Enter the Word");
            string sentence = Console.ReadLine().ToLower();
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == 'a' || sentence[i] == 'e' || sentence[i] == 'i' || sentence[i] == 'o' || sentence[i] == 'u')
                {
                    total++;
                }
            }
            Console.WriteLine("count the number of vowels in the entered Sentence: {0}", total);
            //Console.ReadLine();
        }
    }
}
