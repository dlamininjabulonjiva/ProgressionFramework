using System;

namespace SortAlgorithms.Sorting
{
    public class QuickSort: ISort
    {
        public void Sort(int[] arrayToSort)
        {
            QuickSorting(arrayToSort, 0, arrayToSort.Length - 1);
        }

        public static void QuickSorting(int[] arrayToSort, int left, int right)
        {
            int outerIndex = left, innerIndex = right;
            int pivot = arrayToSort[(left + right) / 2];

            while (outerIndex <= innerIndex)
            {
                while (arrayToSort[outerIndex] < pivot)
                {
                    outerIndex++;
                }
                while (arrayToSort[innerIndex] > pivot)
                {
                    innerIndex--;
                }
                if (outerIndex <= innerIndex)
                {
                    // Swap arr[i] and arr[j]
                    int tmp = arrayToSort[outerIndex];
                    arrayToSort[outerIndex] = arrayToSort[innerIndex];
                    arrayToSort[innerIndex] = tmp;

                    outerIndex++;
                    innerIndex--;
                }
            }

            // Recursive calls
            if (left < innerIndex)
            {
                QuickSorting(arrayToSort, left, innerIndex);
            }

            if (outerIndex < right)
            {
                QuickSorting(arrayToSort, outerIndex, right);
            }
        }
    }
}
