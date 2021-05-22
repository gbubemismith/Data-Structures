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
            // int[] arr = {1, 2, 3, 4, 5, 6};


            var c = SortAlgorithms.freqCnt(new List<string> { "a", "a", "c", "d" });

            var check = Sets.firstRepeatedWord("had had quite enough of this nonsense");


            // Console.WriteLine($"Result {string.Join(',',check)}");


            Console.WriteLine($"Result {check}");
        }
    }
}
