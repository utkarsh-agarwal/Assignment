using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{

    internal class AdjacentPair
    {


        static void maxProduct(int[] arr, int n)
        {
            if (n < 2)
            {
                Console.Write("No pairs exists");
                return;
            }

            int a = arr[0], b = arr[1];

            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    if (arr[i] * arr[j] > a * b)
                    {
                        a = arr[i];
                        b = arr[j];
                    }

            Console.Write("Max product pair is {" +
                              a + ", " + b + "}");
        }

        public static void Main()
        {
            int[] arr = { 1, 4, 3, 6, 7, 0 };
            int n = arr.Length;
            maxProduct(arr, n);
        }
    }

}

