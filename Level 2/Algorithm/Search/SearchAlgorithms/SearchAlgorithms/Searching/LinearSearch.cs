using System;

namespace SearchAlgorithms.Searching
{
    public class LinearSearch
    {
        public int LinearSearching(int[] arrayToSearch, int target)
        {
            for (int index = 0; index < arrayToSearch.Length; index++)
            {
                if (arrayToSearch[index] == target)
                {
                    return index;
                }
            }
            return -1; // If target not found
        }
    }
}
