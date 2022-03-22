using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class FrequecyOfEle
    {
        static void Main(String[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 4, 5, 5, 6, 5, 5 };
            //Array.Sort(arr1);
            //int num = 0;
            //int count = 0;
            //int k = 0;


            //for (int i = 0; i < arr1.Length-1; i++)
            //{
            //    num = arr1[k];
            //    if (num == arr1[i])
            //    {
            //        count++;
            //    }
            //    k++;
            //}
            var freq = arr1.GroupBy(arr1 => arr1).Select(n => new { Key = n.Key, value = n.Count() })
                .OrderByDescending(i => i.value).FirstOrDefault();



            Console.WriteLine(freq.Key + " " + freq.value);
        }
    }
}
