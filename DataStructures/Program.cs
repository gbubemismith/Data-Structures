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
            int[] arr = {1,2,3,4,5};

            var list = new LinkedList();
            list.AddLast(10);
            list.AddLast(40);
            list.AddLast(20);
            list.AddLast(25);
            // list.AddLast(30);
            // list.AddLast(5);
            // list.AddLast(50);


            // list.Reverse();

            //var i = list.GetKthFromTheEnd(3);

            // Array.MaximalPlatform();
            //Array.JaggedArray();

            var leftRot = Array.RotateLeft(arr, 4);
            //var hourGlass = Array.HourGlass();
            //var i = list.PrintMiddle();

            var check = list.ToArray();


            //var check = SortAlgorithms.SmallestElementArr(arr);

            //var check = SortAlgorithms.BubbleSort(arr);
            
            //var check = SortAlgorithms.SelectionSort(arr);

            // var check = RecursionClass.FibonacciNumber(6);

            //find minimum number
            //var check = MinNumber.MinimumNumber(arr);

            //find maximum number
            //var check = MaxNumber.MaximumNumber(arr);

            //find number
            //var check = FindNumber.FindIndex(arr, 2);

            Console.WriteLine($"Result {string.Join(',',check)}");

            // Console.WriteLine($"Result {check}");
        }
    }
}
