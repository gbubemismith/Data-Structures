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
            int[] arr = { -2, -1, 0, 2, 3 };
            // var arr = new char[] { 'A', 'B', 'C', 'B', 'B', 'C' };

            var check = ArrayQuestions.MakeSquares(arr);

            // var check = StringQuestions.MinimumWindowSubstring("aabdec", "abc");

            // var c = SortAlgorithms.freqCnt(new List<string> { "a", "a", "c", "d" });

            // var check = Sets.firstRepeatedWord("had had quite enough of this nonsense");


            // Console.WriteLine($"Result {string.Join(',',check)}");


            Console.WriteLine($"Result {check}");
        }
    }
}
