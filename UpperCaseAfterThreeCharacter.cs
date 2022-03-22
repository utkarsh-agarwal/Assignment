using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class UpperCaseAfterThreeCharacter
    {
        static string lastthree(string sent)
        {
            int len = sent.Length;
            int len2 = sent.Length - 3;
            Console.WriteLine(len2);
            string apend = "";
            if (sent.Length < 3)
            {
                apend = sent.ToUpper();
                return apend;
            }
            else
            {
                apend = sent.Substring(0, len2) + sent.Substring(len - 3).ToUpper();
                return apend;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String:");
            string word = Console.ReadLine();
            Console.WriteLine(word.Length);
            Console.WriteLine(lastthree(word));
        }
    }
}
