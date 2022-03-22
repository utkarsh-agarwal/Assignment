using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Assignment
{
    internal class EleNotInSecondArray
    {
        static void Main(String[] args)
        {
            int[] arr1 = { 1, 2, 3, 5, 8 };
            int[] arr2 = { 1, 4, 6, 2, 9, 5 };
            Array.Sort(arr1);
            Array.Sort(arr2);
            var at = arr2.Except(arr1);
            var arrAll = arr1.Union(arr2);


            Console.WriteLine(String.Join(",", at));
            Console.WriteLine(String.Join(",", arrAll));


        }
    }
}
