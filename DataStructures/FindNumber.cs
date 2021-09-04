using System.Collections.Generic;

namespace DataStructures
{
    public class FindNumber
    {
        public static int FindIndex(int[] arr, int num)
        {
            // takes an array of integers and an integer to find, then returns index of element if exists otherwise -1
            // 1, 2, 3, 4

            var index = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    index = i;
                }
            }


            return index;
        }

        public static int[] TwoSum(int[] arr, int target)
        {
            //[2, 7, 11, 15]  13

            target = 542;

            var map = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                var otherSum = target - arr[i];

                if (map.ContainsKey(otherSum) && !(map.ContainsKey(arr[i])))
                    return new int[] { map[otherSum], i };


                map.Add(arr[i], i);

            }


            return new int[] { };
        }

        public static int[] TwoSumPointer(int[] arr, int target)
        {

            int left = 0, right = arr.Length - 1;

            while (left < right)
            {
                int currentSum = arr[left] + arr[right];

                if (currentSum == target)
                    return new int[] { left, right };

                if (target > currentSum)
                    left++;
                else
                    right--;
            }

            return new int[] { -1, -1 };

        }

        public static int GetSequenceSum(int i, int j, int k)
        {
            int sum1 = 0;

            // i = 5 -5
            // j = 9 -1
            // k = 6 -3

            for (int m = i; m <= j; m++)
            {
                sum1 = sum1 + m;
            }

            int sum2 = sum1;

            for (int n = j; n > k; n--)
            {
                sum2 = sum2 + (n - 1);
            }

            return sum2;
        }
    }
}