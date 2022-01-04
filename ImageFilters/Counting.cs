using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilters
{
   
    internal class Counting
    {
        
        public  byte[] CountingSort(byte[] Array, int ArrayLength, byte Min, byte Max)
        {
            
            byte[] count = new byte[ArrayLength];
            int z = 0;
            for (int i = 0; i < count.Length; i++)
                count[i] = 0;
            for(int n =0;n<ArrayLength;n++)
            {
                for(int c=1;c<ArrayLength;c++)
                {
                    if (Array[n] >= Array[c])
                    {
                        count[n]++;
                    }
                    else
                    {
                        continue;
                    }

                }
            }
            for(int v=0;v<ArrayLength;v++)
            {
                Array[count[v]] = Array[v];
            }          
            return Array;
        }


    }
}
