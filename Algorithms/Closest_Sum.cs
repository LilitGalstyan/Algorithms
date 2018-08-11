using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Closest_Sum
    {
        static void ClosestNumers(int[] arr, int n, int x)
        {
            int result_left = 0;
            int result_right = 0;

            int left = 0;
            int right = n - 1;
            int difference = int.MaxValue;

            while (right > left)
            {
                if (Math.Abs(arr[left] + arr[right] - x) < difference)
                {
                    result_left = left;
                    result_right = right;
                    difference = Math.Abs(arr[left] + arr[right] - x);
                }

                if (arr[left] + arr[right] > x)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }

            Console.WriteLine($"The closest pair is {arr[result_left]} and {arr[result_right]}");
        }
    }
}
