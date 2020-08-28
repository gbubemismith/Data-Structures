namespace DataStructures
{
    public class MaxNumber
    {
        public static int MaximumNumber(int [] arr) 
        {

            // [1, 2, 3, 4]

            int maxVal = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                
                if (maxVal < arr[i])
                {
                    maxVal = arr[i];
                }

            }

            return maxVal;
        }
    }
}