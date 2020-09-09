using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    public class SortAlgorithms
    {
        public static int[] SelectionSort(int[] arr)
        {
            int minindex;

            //6,2,4,3,5

            for (int i = 0; i < arr.Length; i++)
            {
                minindex = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minindex])
                    {
                        minindex = j;
                    }
                }

                //swap 
                int temp = arr[i];
                arr[i] = arr[minindex];
                arr[minindex] = temp;
            }


            return arr;
        }

        public static int[] BubbleSort(int[] arr) 
        {
            //4 2 1 5 0

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[j];
                        
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            return arr;
        }

        public static int SmallestElementArr(int[] arr)
        {

            int smallestElement = arr[0];

            //3 4 1 5

            for (int i = 1; i < arr.Length; i++)
            {
                if (smallestElement >  arr[i])
                {
                    smallestElement = arr[i];
                }

            }


            return smallestElement;
        }

        

      
    }
}