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

            var list = new DoublyLinkedList();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            // list.AddLast(4);
            // list.AddLast(10);

            // list.AddLast(25);
            //list.InsertAfter(8, 2);
            list.InsertIntoSorted(4);
            // list.InsertAt(1, 2);
            

            // Console.WriteLine($"Result {string.Join(',',check)}");

            // Console.WriteLine($"Result {check}");
        }
    }
}
