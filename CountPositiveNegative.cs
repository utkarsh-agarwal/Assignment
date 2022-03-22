using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class CountPositiveNegative
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int pcount = 0, ncount = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + "  ");
                if (arr[i] <= 0)
                    ncount++;
                else
                    pcount++;
            }
            Console.WriteLine($"\nThere are {pcount} positive numbers and {ncount} negative numbers");
        }
    }
}
