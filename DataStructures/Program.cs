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
            int[] arr = { 2, 1, 5, 1, 3, 2 };

            var check = ArrayQuestions.MaximumSum(3, arr);

            // var c = SortAlgorithms.freqCnt(new List<string> { "a", "a", "c", "d" });

            // var check = Sets.firstRepeatedWord("had had quite enough of this nonsense");


            // Console.WriteLine($"Result {string.Join(',',check)}");


            Console.WriteLine($"Result {check}");
        }
    }
}
