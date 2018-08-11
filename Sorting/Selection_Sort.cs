using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Selection_Sort
    {
        static void Swap(int[] items, int left, int right)
        {
            if (left != right)
            {
                int temp = items[left];
                items[left] = items[right];
                items[right] = temp;
            }
        }

        public static void SelectionSort(int[] items)
        {
            int sortedRangeEnd = 0;

            while (sortedRangeEnd < items.Length)
            {
                int nextIndex = FindOndexOfSmallestFromIndex(items, sortedRangeEnd);
                Swap(items, sortedRangeEnd, nextIndex);
                sortedRangeEnd++;
            }
        }

        private static int FindOndexOfSmallestFromIndex(int[] items, int sortedRangeEnd)
        {
            int currentSmallest = items[sortedRangeEnd];
            int currentSmallestIndex = sortedRangeEnd;

            for (int i = sortedRangeEnd + 1; i < items.Length; i++)
            {
                if (currentSmallest.CompareTo(items[i]) > 0)
                {
                    currentSmallest = items[i];
                    currentSmallestIndex = i;
                }
            }

            return currentSmallestIndex;
        }
    }
}
