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

            var list = new SinglyLinkedList();
            list.AddLast(16);
            list.AddLast(13);
            list.AddLast(7);
            // list.AddLast(25);

            list.InsertAt(1, 2);
            

            // Console.WriteLine($"Result {string.Join(',',check)}");

            // Console.WriteLine($"Result {check}");
        }
    }
}
