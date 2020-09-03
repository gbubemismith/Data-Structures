using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {   
           

            //array to test with
            int [] arr = {2,4,6,3,5,7,9,1,8};
            
            var numbers = new Array(4);
            numbers.Insert(5);
            numbers.Insert(10);
            numbers.Insert(20);
            numbers.Insert(30);

            numbers.InsertAt(8, 2);



            var check = SortAlgorithms.SmallestElementArr(arr);

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
