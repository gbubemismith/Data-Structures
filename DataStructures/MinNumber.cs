namespace DataStructures
{
    public class MinNumber
    {
        public static int MinimumNumber(int[] arr)
        {
            var minVal = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (minVal > arr[i])
                {
                    minVal = arr[i];
                }
            }

            return minVal;

        }
    }
}