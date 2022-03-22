using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class MultipleOfThreeSeven
    {
        static bool multiple(int n)
        {
            if ((n % 3) == 0 || (n % 7) == 0)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int no = int.Parse(Console.ReadLine());
            Console.WriteLine(multiple(no));
        }
    }
}
