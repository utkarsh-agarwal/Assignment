using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class TwoArraysCommonEle
    {
        static void Main(String[] args)
        {
            int[] arr1 = { 1, 2, 3, 5, 8 };
            int[] arr2 = { 1, 4, 6, 2, 9, 5 };
            int[] arr3 = new int[arr1.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        arr3[i] = arr2[j];
                    }
                }
            }
            for (int i = 0; i < arr3.Length; i++)
            {
                if(arr3[i] !=0)
                Console.Write(arr3[i]+" ");
            }
        }
    }
}
