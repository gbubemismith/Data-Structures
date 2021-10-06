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
            int[] arr = { 5, 7, 1, 2, 8, 4, 3 };
            // var arr = new char[] { 'A', 'B', 'C', 'B', 'B', 'C' };

            // var check = StringQuestions.GetRecipient("@User_One @UserABC! Have you seen this from @Userxyz?", 2);

            var check = ArrayQuestions.TargetSum(10, arr);

            // var check = StringQuestions.codeHere("Four score and seven years ago our fathers brought forth upon this continent a new nation, conceived in liberty and dedicated to the proposition that all men are created equal");

            // var check = StringQuestions.LongestNiceSubstring("YazaAay");

            // var c = SortAlgorithms.freqCnt(new List<string> { "a", "a", "c", "d" });

            // var check = Sets.firstRepeatedWord("had had quite enough of this nonsense");


            // Console.WriteLine($"Result {string.Join(',',check)}");


            Console.WriteLine($"Result {check}");
        }
    }
}
