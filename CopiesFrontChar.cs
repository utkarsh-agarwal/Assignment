using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class CopiesFrontChar
    {
        static string repeat(string sent)
        {
            string apend = "";
            if (sent.Length < 2)
            {
                apend = sent;
                return apend;
            }
            else
            {
                char num = sent[0];
                char num2 = sent[1];
                apend = num.ToString();
                apend = apend + num2.ToString();
                for (int i = 0; i < 2; i++)
                {
                    apend += apend;
                }
                return apend;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String:");
            string name = Console.ReadLine();
            Console.WriteLine(repeat(name));
        }
    }
}
