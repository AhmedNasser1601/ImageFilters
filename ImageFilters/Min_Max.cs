using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilters
{
    internal class Min_Max
    {
        public byte[] Mi(byte[] arr)
        {
            int i = 0;
            byte x = 255;
            byte y = 0;
            for (i = 0; i < arr.Length; i++)
            {
                if (i != arr.Length)
                {
                    x = Math.Min(x, arr[i]);
                    y = Math.Max(x, arr[i]);
                }
                else
                {
                    break;
                }


            }

            byte[] z = { x, y };
            return z;
        }
    }
}
