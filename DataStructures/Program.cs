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
            int[] arr = {1, 2, 3, 4, 5, 6};

            // var check = StringQuestions.CountVowels("Hello World");
            var check = StringQuestions.ReverseWords("I am God");

            // var check = SearchAlgorithms.BinarySearch(arr, 5);

            // var check = SearchAlgorithms.LinearSearch(arr, 2);

            // SortAlgorithms.CountingSort(arr, 5);

            // var check = Array.MoveZeros(arr);
            

            // Console.WriteLine($"Result {string.Join(',',check)}");

            Console.WriteLine($"Result {check}");
        }
    }
}
