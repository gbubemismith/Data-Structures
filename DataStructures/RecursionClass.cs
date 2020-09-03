using System;

namespace DataStructures
{
    public class RecursionClass
    {
        public static long FibonacciNumber(int n)
        {
            //4
          
            if (n <= 2)
            {
                return 1;
            }

            return FibonacciNumber(n - 1) + FibonacciNumber(n - 2);
         

        }

        
    }
}