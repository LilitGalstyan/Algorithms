using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Inversions
    {
        static int Merge(int[] arr, int[] temp, int left, int middle, int right)
        {
            int inv_count = 0;

            int i = left;
            int j = middle;
            int k = left;

            while ((i <= middle - 1) && (j <= right))
            {
                if (arr[i] <= arr[j])
                {
                    temp[k++] = arr[i++];
                }
                else
                {
                    temp[k++] = arr[j++];
                    inv_count += (middle - i);
                }

            }
            while (i <= middle - 1)
            {
                temp[k++] = arr[i++];
            }
            while (j <= right)
            {
                temp[k++] = arr[j++];
            }

            for (i = left; i <= right; i++)
            {
                arr[i] = temp[i];
            }

            return inv_count;
        }

        static int MergeSort(int[] arr, int[] temp, int left, int right)
        {
            int middle;
            int inv_count = 0;

            if (right > left)
            {
                middle = (right + left) / 2;

                inv_count = MergeSort(arr, temp, left, middle);
                inv_count += MergeSort(arr, temp, middle + 1, right);
                inv_count += Merge(arr, temp, left, middle + 1, right);
            }

            return inv_count;
        }

        static int NumberOfInversions(int[] arr, int arr_size)
        {
            int[] temp = new int[arr_size];

            return MergeSort(arr, temp, 0, arr_size - 1);
        }
    }
}
