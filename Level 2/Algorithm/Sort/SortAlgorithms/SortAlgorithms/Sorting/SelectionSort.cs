using System;

namespace SortAlgorithms.Sorting
{
    public class SelectionSort: ISort
    {
        public void Sort(int[] arrayToSort)
        {
            int arrayLength = arrayToSort.Length;

            for (int outerIndex = 0; outerIndex < arrayLength - 1; outerIndex++)
            {
                int minIndex = outerIndex;

                for (int innerIndex = outerIndex + 1; innerIndex < arrayLength; innerIndex++)
                {
                    if (arrayToSort[innerIndex] < arrayToSort[minIndex])
                    {
                        minIndex = innerIndex;
                    }
                }

                if (minIndex != outerIndex)
                {
                    int temp = arrayToSort[minIndex];
                    arrayToSort[minIndex] = arrayToSort[outerIndex];
                    arrayToSort[outerIndex] = temp;
                }
            }
        }
    }
}
