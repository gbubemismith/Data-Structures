using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    public class SortAlgorithms
    {
        public static int[] BubbleSort(int[] arr)
        {

            // { 2, 4, 1, 3}

            bool isSorted = true;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < arr.Length - i; j++)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        Swap(arr, j, j - 1);
                        
                        isSorted = false;
                    }
                }

                if (isSorted)
                    return arr;
                
            }

            return arr;
        }

        public static int[] SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                var minIndex = i;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                        
                }

                Swap(arr, minIndex, i);
            }

            return arr;
        }

        public static int[] InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                var current = arr[i];
                var j = i - 1; //index 0

                while (j >= 0 && arr[j] > current)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = current;

            }

            return arr;
        }

        public static void MergeSort(int[] arr)
        {
            if (arr.Length < 2)
                return ;
              

            //divide array into two 
            var middle = arr.Length / 2;

            //create new array for left partition
            var left = new int[middle];

            //fill left partition
            for (int i = 0; i < middle; i++)
                left[i] = arr[i];

            //create new array for right partition
            var right = new int[arr.Length - middle];
            for (int i = middle; i < arr.Length; i++)
                right[i - middle] = arr[i];

            
            //sort recursively
            MergeSort(left);
            MergeSort(right);

            //merge the result
            Merge(left, right, arr);
        

        }

        private static void Merge(int[] left, int[] right, int[] result)
        {
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    result[k] = left[i];
                    k++;
                    i++;
                }
                else
                {
                    result[k] = right[j];
                    k++;
                    j++;
                }
                    
            }


            //if one partition is larger than the other
            while (i < left.Length)
            {
                result[k] = left[i];
                k++;
                i++;
            }

            while (j < right.Length)
            {
                result[k] = right[j];
                k++;
                j++;
            }
        }
     
        private static void Swap(int[] arr, int index1, int index2)
        {
            var temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }
        

      
    }
}