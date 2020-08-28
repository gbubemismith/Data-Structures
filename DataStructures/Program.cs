using System;
using Microsoft.Extensions.DependencyInjection;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //array to test with
            int [] arr = {2,4,6,3,5,7,9,1,8};

            //find minimum number
            var check = MinNumber.MinimumNumber(arr);

            //find maximum number
            //var check = MaxNumber.MaximumNumber(arr);

            //find number
            //var check = FindNumber.FindIndex(arr, 2);

            Console.WriteLine($"Result {check}");
        }
    }
}
