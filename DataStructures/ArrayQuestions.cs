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
    }
}