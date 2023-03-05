using SortAlgorithms.Sorting;

namespace SortAlgorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arrayToSortForSelectionSort = { 64, 25, 12, 22, 11 };
            SelectionSortOutput(arrayToSortForSelectionSort);

            int[] arrayToSortForQuickSort = { 5, 2, 7, 3, 9, 1, 4, 6, 8 };
            QuickSortOutput(arrayToSortForQuickSort);

            int[] arrayToSortForMergeSort = { 38, 27, 43, 3, 9, 82, 10 };
            MergeSortOutput(arrayToSortForMergeSort);
        }

        public static void SelectionSortOutput(int[] arrayToSortForSelectionSort)
        {
            Console.WriteLine("Array for Selection Sort before sorting:");
            PrintArray(arrayToSortForSelectionSort);

            var selectionSort = new SelectionSort();
            selectionSort.Sort(arrayToSortForSelectionSort);

            Console.WriteLine("Array for Selection Sort after sorting:");
            PrintArray(arrayToSortForSelectionSort);
            Console.WriteLine("----------------------------------------------------------------------------------");
        }

        public static void QuickSortOutput(int[] arrayToSortForQuickSort)
        {
            Console.WriteLine("Array for Quick Sort before sorting:");
            PrintArray(arrayToSortForQuickSort);

            var quickSort = new QuickSort();
            quickSort.Sort(arrayToSortForQuickSort);

            Console.WriteLine("Array for Quick Sort after sorting:");
            PrintArray(arrayToSortForQuickSort);
            Console.WriteLine("----------------------------------------------------------------------------------");
        }

        public static void MergeSortOutput(int[] arrayToSortForMergeSort)
        {
            Console.WriteLine("Array for Merge Sort before sorting:");
            PrintArray(arrayToSortForMergeSort);

            var mergeSort = new MergeSort();
            mergeSort.Sort(arrayToSortForMergeSort);

            Console.WriteLine("Array for Merge Sort after sorting:");
            PrintArray(arrayToSortForMergeSort);
        }

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
