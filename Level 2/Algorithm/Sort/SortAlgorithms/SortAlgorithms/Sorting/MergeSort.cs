using System;

namespace SortAlgorithms.Sorting
{
    public class MergeSort: ISort
    {
        public void Sort(int[] arrayToSort)
        {
            MergeSorting(arrayToSort, 0, arrayToSort.Length - 1);
        }

        public static void MergeSorting(int[] arrayToSort, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSorting(arrayToSort, left, middle);
                MergeSorting(arrayToSort, middle + 1, right);

                Merge(arrayToSort, left, middle, right);
            }
        }

        public static void Merge(int[] arrayToSort, int left, int middle, int right)
        {
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            Array.Copy(arrayToSort, left, leftArray, 0, middle - left + 1);
            Array.Copy(arrayToSort, middle + 1, rightArray, 0, right - middle);

            int outerIndex = 0, innerIndex = 0, k = left;

            while (outerIndex < leftArray.Length && innerIndex < rightArray.Length)
            {
                if (leftArray[outerIndex] <= rightArray[innerIndex])
                {
                    arrayToSort[k++] = leftArray[outerIndex++];
                }
                else
                {
                    arrayToSort[k++] = rightArray[innerIndex++];
                }
            }

            while (outerIndex < leftArray.Length)
            {
                arrayToSort[k++] = leftArray[outerIndex++];
            }

            while (innerIndex < rightArray.Length)
            {
                arrayToSort[k++] = rightArray[innerIndex++];
            }
        }
    }
}
