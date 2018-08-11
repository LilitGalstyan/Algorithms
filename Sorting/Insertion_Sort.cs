using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Insertion_Sort
    {
        public static void InsertionSort(int[] items)
        {
            int sortedRangeEndIndex = 1;

            while (sortedRangeEndIndex < items.Length)
            {
                if (items[sortedRangeEndIndex].CompareTo(items[sortedRangeEndIndex - 1]) < 0)
                {
                    int insertIndex = FindInsertionIndex(items, items[sortedRangeEndIndex]);
                    Insert(items, insertIndex, sortedRangeEndIndex);
                }

                sortedRangeEndIndex++;
            }
        }

        private static int FindInsertionIndex(int[] items, int valueToInsert)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].CompareTo(valueToInsert) > 0)
                {
                    return i;
                }
            }

            throw new InvalidOperationException("The index is not found");
        }

        private static void Insert(int[] itemArray, int indexInsertingAt, int indexInsertingFrom)
        {
            int temp = itemArray[indexInsertingAt];
            itemArray[indexInsertingAt] = itemArray[indexInsertingFrom];

            for (int current = indexInsertingFrom; current > indexInsertingAt; current--)
            {
                itemArray[current] = itemArray[current - 1];
            }

            itemArray[indexInsertingAt + 1] = temp;
        }
    }
}
