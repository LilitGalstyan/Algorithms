using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Quick_Sort
    {
        static int Partitioning(int[] arr, int low, int high)
        {
            int pivot = arr[high];

            int i = (low - 1);

            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

        static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partitioning(arr, low, high);

                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }

        static void Print(int[] arr, int n)
        {
            for (int i = 0; i < n; ++i)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
