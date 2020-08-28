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
    }
}