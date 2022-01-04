using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilters
{
    internal class Quick
    {
     
        public int PARTITION(byte[] Arr, int L, int R)
        {
           
            byte Temp;
            int pivot = L;
            for (int j = L ; j < R ; j++)
            {
                if (Arr[j] <= Arr[R])
                {
                    Temp = Arr[j];
                    Arr[j] = Arr[pivot];
                    Arr[pivot++] = Temp;

                }
            }
            Temp = Arr[pivot];
            Arr[pivot] = Arr[R];
            Arr[R] = Temp;
            return pivot;
        }
        public byte[] QUICK_SORT(byte[] Arr, int L, int R)
        {
            if (L < R)
            {
                int pivot = PARTITION(Arr, L , R);
                QUICK_SORT(Arr, L, pivot - 1);
                QUICK_SORT(Arr, pivot + 1, R);
            }
            return Arr;
        }


    }
}

