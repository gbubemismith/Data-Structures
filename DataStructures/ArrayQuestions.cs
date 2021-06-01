using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures
{
    public class ArrayQuestions
    {
        public static double[] FindAverages(int k, int[] arr)
        {
            //brute approach; complexity 0(n^2)
            // var result = new double[arr.Length - k + 1];

            // for (int i = 0; i <= arr.Length - k; i++)
            // {
            //     double sum = 0;
            //     for (int j = i; j < k + i; j++)
            //     {
            //         sum += arr[j];
            //     }

            //     result[i] = sum / k;
            // }

            // return result;

            //using sliding window pattern

            var result = new double[arr.Length - k + 1];
            double windowSum = 0;
            int windowStart = 0;

            for (int windowEnd = 0; windowEnd < arr.Length; windowEnd++)
            {
                //keep adding
                windowSum += arr[windowEnd];

                //if windowEnd >= 5th index after start, find avaerage and 
                if (windowEnd >= k - 1)
                {
                    result[windowStart] = windowSum / k; //get average
                    windowSum -= arr[windowStart]; //subtract start element
                    windowStart++; //move to the next 

                }

            }


            return result;
        }

        //using sliding window pattern
        public static int MaximumSum(int k, int[] arr)
        {
            int maxSum = 0;
            int windowSum = 0;
            int windowStart = 0;

            for (int windowEnd = 0; windowEnd < arr.Length; windowEnd++)
            {
                windowSum += arr[windowEnd];

                if (windowEnd >= k - 1)
                {
                    if (maxSum < windowSum)
                        maxSum = windowSum;

                    windowSum -= arr[windowStart];
                    windowStart++;
                }

            }

            return maxSum;
        }

        public static int SmallestSubarrayLength(int s, int[] arr)
        {
            int windowStart = 0;
            int windowSum = 0;
            int minLength = int.MaxValue;

            for (int windowEnd = 0; windowEnd < arr.Length; windowEnd++)
            {
                windowSum += arr[windowEnd];

                while (windowSum >= s)
                {
                    int count = windowEnd - windowStart + 1;
                    //get the minimum length
                    if (minLength > count)
                        minLength = count;

                    windowSum -= arr[windowStart];
                    windowStart++;
                }
            }

            return minLength == int.MaxValue ? 0 : minLength;
        }

        public static int MaxFruitCountOfTwoTypes(char[] arr)
        {
            var map = new Dictionary<char, int>();

            int windowStart = 0, maxLength = 0;

            for (int windowEnd = 0; windowEnd < arr.Length; windowEnd++)
            {
                var fruitValue = arr[windowEnd];

                if (map.TryGetValue(fruitValue, out var val))
                    map[fruitValue] = val + 1;
                else
                    map.Add(fruitValue, 1);

                //while fruits type not more than 2
                while (map.Count > 2)
                {
                    var previousFruitEntered = arr[windowStart];
                    map[previousFruitEntered] = map[previousFruitEntered] - 1;

                    if (map[previousFruitEntered] == 0)
                        map.Remove(previousFruitEntered);

                    windowStart++;
                }

                maxLength = Math.Max(maxLength, windowEnd - windowStart + 1);

            }

            // //add values here
            // foreach (var item in map)
            // {
            //     maxLength += item.Value;
            // }

            //using linq
            // maxLength = map.Sum(x => x.Value);

            return maxLength;
        }

        public static int LongestSubarrayReplacement(int[] arr, int k)
        {
            int windowStart = 0;
            // int maxLength = 0, maxOnesCount = 0;

            // //[0, 1, 1, 0, 0, 0, 1, 1, 0, 1, 1]
            // for (int windowEnd = 0; windowEnd < arr.Length; windowEnd++)
            // {
            //     if (arr[windowEnd] == 1)
            //         maxOnesCount++;


            //     if (windowEnd - windowStart + 1 - maxOnesCount > k)
            //     {
            //         if (arr[windowStart] == 1)
            //             maxOnesCount--;

            //         windowStart++;
            //     }

            //     maxLength = Math.Max(maxLength, windowEnd - windowStart + 1);
            // }

            //ALTERNATIVE
            int maxLength = 0, maxZerosCount = 0;

            //[0, 1, 1, 0, 0, 0, 1, 1, 0, 1, 1]
            for (int windowEnd = 0; windowEnd < arr.Length; windowEnd++)
            {
                if (arr[windowEnd] == 0)
                    maxZerosCount++;


                if (maxZerosCount > k)
                {
                    if (arr[windowStart] == 0)
                        maxZerosCount--;

                    windowStart++;
                }

                maxLength = Math.Max(maxLength, windowEnd - windowStart + 1);
            }


            return maxLength;
        }
    }
}