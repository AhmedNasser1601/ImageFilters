using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilters
{
    internal class Average
    {
        
        public int aver(byte [] Array)
        {
            int sum = 0;
            
            int av = 0;
            for (int i=0;i<Array.Length;i++)
            {
                sum+=Array[i];
            }
            if(Array.Length > 0)
            {
               av = sum / Array.Length;
            }
           
            return av;
        }
    }
}
