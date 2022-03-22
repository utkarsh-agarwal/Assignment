using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class RemoveFirstAndLast
    {
        public static void Main(string[] args)
        {
            
           
            String str = Console.ReadLine();
            String str2 = str .Length > 2 ? str .Substring(1, str .Length - 2) : str;
            Console.WriteLine(str2);
        }
    }
}
