using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class ListofIntegers
    {
        public static int ConsecutiveArray(int[] a)
        {
            Array.Sort(a);
            int count = 0;
            for (int i = 0; i < a.Length - 1; i++)
            {
                count += a[i + 1] - a[i] - 1;
            }
            return count;
        }

        public static void Main(String[] args)
        {
            int[] a = { 1, 3, 5, 6, 9 };
            Console.WriteLine(ConsecutiveArray(a));
            
        }
    }
}

