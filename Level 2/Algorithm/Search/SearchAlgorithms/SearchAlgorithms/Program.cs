using SearchAlgorithms.Searching;

namespace SearchAlgorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arrayToSearchForBanarySearch = { 1, 3, 5, 7, 9 };
            int targetForBanarySearch = 7;
            BinarySearchOutPut(arrayToSearchForBanarySearch, targetForBanarySearch);

            int[] arrayToSearchForLinearSearch = { 10, 20, 30, 40, 50, 60, 70 };
            int targetForLinearSearch = 40;
            LinearSearchOutPut(arrayToSearchForLinearSearch, targetForLinearSearch);
        }

        public static void BinarySearchOutPut(int[] arrayToSearchForBanarySearch, int targetForBanarySearch)
        {
            Console.WriteLine("----------------------Binary Search------------------------------------");
            var binarySearch = new BinarySearch();
            int iterativeResult = binarySearch.BinarySearchIterative(arrayToSearchForBanarySearch, targetForBanarySearch);
            int recursiveResult = binarySearch.BinarySearchRecursive(arrayToSearchForBanarySearch, targetForBanarySearch);

            Console.WriteLine($"Iterative: Found {targetForBanarySearch} at index {iterativeResult}");
            Console.WriteLine($"Recursive: Found {targetForBanarySearch} at index {recursiveResult}");
        }

        public static void LinearSearchOutPut(int[] arrayToSearchForLinearSearch, int targetForLinearSearch)
        {
            Console.WriteLine("----------------------Linear Search------------------------------------");
            var linearSearch = new LinearSearch();
            int index = linearSearch.LinearSearching(arrayToSearchForLinearSearch, targetForLinearSearch);

            if (index != -1)
            {
                Console.WriteLine("Target found at index: " + index);
            }
            else
            {
                Console.WriteLine("Target not found");
            }
        }
    }
}
