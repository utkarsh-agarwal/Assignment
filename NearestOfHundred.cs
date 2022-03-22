using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class NearestOfHundred
    {
        static int nearest(int[] arr)
        {
            int num = 100 - arr[0];
            int num2 = 100 - arr[1];
            if (num < num2)
                return (100 - num);
            else if (num2 == num)
                return 0;
            else
                return (100 - num2);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter two comma separated numbers=");
            string input = Console.ReadLine();
            string[] inputs = input.Split(',');
            int[] numbers = new int[inputs.Length];
            numbers[0] = int.Parse(inputs[0]);
            numbers[1] = int.Parse(inputs[1]);
            Console.WriteLine(nearest(numbers));
        }
    }
}
