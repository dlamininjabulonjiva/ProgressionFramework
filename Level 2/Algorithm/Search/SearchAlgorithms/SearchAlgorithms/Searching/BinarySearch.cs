using System;

namespace SearchAlgorithms.Searching
{
    public class BinarySearch
    {
        public int BinarySearchIterative(int[] arrayToSearch, int target)
        {
            int left = 0;
            int right = arrayToSearch.Length - 1;

            while (left <= right)
            {
                int middle = left + (right - left) / 2;

                if (arrayToSearch[middle] == target)
                {
                    return middle;
                }

                if (arrayToSearch[middle] < target)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            return -1;
        }

        public int BinarySearchRecursive(int[] arrayToSearch, int target)
        {
            return BinarySearchRecursiveHelper(arrayToSearch, target, 0, arrayToSearch.Length - 1);
        }

        private static int BinarySearchRecursiveHelper(int[] arrayToSearch, int target, int left, int right)
        {
            if (left > right)
            {
                return -1;
            }

            int middle = left + (right - left) / 2;

            if (arrayToSearch[middle] == target)
            {
                return middle;
            }

            if (arrayToSearch[middle] < target)
            {
                return BinarySearchRecursiveHelper(arrayToSearch, target, middle + 1, right);
            }
            else
            {
                return BinarySearchRecursiveHelper(arrayToSearch, target, left, middle - 1);
            }
        }
    }
}
