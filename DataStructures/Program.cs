using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {   
           

            //array to test with
            int[] arr = {7, 10, 4, 3, 20, 15};

            SortAlgorithms.MergeSort(arr);
            

            Console.WriteLine($"Result {string.Join(',',arr)}");

            // Console.WriteLine($"Result {check}");
        }
    }
}
