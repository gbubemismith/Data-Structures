namespace DataStructures
{
    public class SearchAlgorithms
    {
        public static int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                    return i;
            }


            return -1;
        }

        public static int BinarySearch(int[] arr, int target)
        {
            // return BinarySearchRecursive(arr, target, 0, arr.Length - 1);
            return BinarySearchIteration(arr, target);
        }

        private static int BinarySearchRecursive(int[] arr, int target, int left, int right)
        {
            if (right < left)
                return -1;


            var middle = (left + right) / 2;

            if (arr[middle] == target)
                return middle;

            if (target < arr[middle])
                return BinarySearchRecursive(arr, target, left, middle - 1);

            return BinarySearchRecursive(arr, target, middle + 1, right);

        }

        private static int BinarySearchIteration(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {   
                var middle = (left + right) / 2;

                if (arr[middle] == target)
                    return middle;

                if (target < arr[middle])
                    right = middle - 1;
                else
                    left = middle + 1;
                
            } 


            return -1;
        }
    }
}