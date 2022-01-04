//CountingSort

using System;
using System.Diagnostics;
using System.Linq;

namespace CountingSort
{
    class Program
    {
       

      public int[] comparison_counting_sort(int[] list)
        {
            int[] count = Enumerable.Repeat(0, list.Length).ToArray();

            int[] result = new int[list.Length];

            for (int i = 0; i < list.Length - 1; i++)
            {
                for (int j = i + 1; j < list.Length; j++)
                {
                    if (list[i] < list[j])
                        count[j] = count[j] + 1;
                    else
                        count[i] = count[i] + 1;
                }
            }

            for (int k = 0; k < list.Length; k++)
            {
                result[count[k]] = list[k];
            }

            return result;
        }

        public int[] distribution_counting_sort(int[] list, int min, int max)
        {

            int[] D = Enumerable.Repeat(0, max - min + 1).ToArray();
            int[] result = new int[list.Length];

            for (int i = 0; i < list.Length; i++)
            {
                D[list[i] - min] += 1;
            }

            for (int j = 1; j < max - min + 1; j++)
            {
                D[j] = D[j - 1] + D[j];
            }

            for (int k = list.Length - 1; k >= 0; k--)
            {
                int l = list[k] - min;
                result[D[l] - 1] = list[k];
                D[l] -= 1;
            }

            return result;
        }
    }
}