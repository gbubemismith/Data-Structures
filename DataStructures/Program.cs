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

            var check = StringQuestions.PrintAllOdd("");

            // var check = ArrayQuestions.MakeSquares(arr);

            // var check = StringQuestions.codeHere("Four score and seven years ago our fathers brought forth upon this continent a new nation, conceived in liberty and dedicated to the proposition that all men are created equal");

            // var check = StringQuestions.LongestNiceSubstring("YazaAay");

            // var c = SortAlgorithms.freqCnt(new List<string> { "a", "a", "c", "d" });

            // var check = Sets.firstRepeatedWord("had had quite enough of this nonsense");


            // Console.WriteLine($"Result {string.Join(',',check)}");


            Console.WriteLine($"Result {check}");
        }
    }
}
