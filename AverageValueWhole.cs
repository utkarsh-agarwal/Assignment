using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class AverageValueWhole
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
            Console.WriteLine("The given Array Average is:");
            int sum = 0; double avg = 0.0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "  ");
                sum += arr[i];
            }
            avg = (double)sum / (double)arr.Length;
            bool success = ((avg % 1) == 0);
            if (success)
            {
                Console.WriteLine(" a Whole Number");
            }
            else
                Console.WriteLine("is Not a Whole Number");
        }
    }
}
 
