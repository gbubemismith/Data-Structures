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
            int[] arr = { 0, 1, 1, 0, 0, 0, 1, 1, 0, 1, 1 };
            // var arr = new char[] { 'A', 'B', 'C', 'B', 'B', 'C' };

            // var check = ArrayQuestions.LongestSubarrayReplacement(arr, 2);

            var check = StringQuestions.FindPermutation("aaacb", "abc");

            // var c = SortAlgorithms.freqCnt(new List<string> { "a", "a", "c", "d" });

            // var check = Sets.firstRepeatedWord("had had quite enough of this nonsense");


            // Console.WriteLine($"Result {string.Join(',',check)}");


            Console.WriteLine($"Result {check}");
        }
    }
}
