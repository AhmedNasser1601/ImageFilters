using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilters
{
    internal class Zg
    {
        int s = 3;
        public double [] xaxis(int MW)
        {
            double[] xa = new double[40];
            for (int x = 0; x <= MW ; x++)
            {
                if (s <= MW)
                {
                    xa[x] = s;
                    s += 2;
                }
            }
            return xa;
        }
       
    }
}
