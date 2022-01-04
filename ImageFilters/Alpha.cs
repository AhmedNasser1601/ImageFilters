using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilters
{
    internal class Alpha
    {

        public void neighbour(byte[,]imagematrix,int i, int j, int ws, byte[] pixel )
        {
            pixel = new byte[ws*ws];
            int a1 = i - (ws / 2);
            int b1 = j - (ws / 2);
            int a2 = i - (ws / 2);
            int b2 = j - (ws / 2);
            for(int a=a1; i<a2;i++)
            {
                for(int b=b1; j<b2;j++)
                {
                    pixel[a]=imagematrix[a,b];
                }

            }

        }
        public byte[,] Al(byte[,] Image, int sort, int T, int WS, int maW)
        {
            int hieght = ImageOperations.GetHeight(Image);
            int width = ImageOperations.GetWidth(Image);
            byte[,] newimage = new byte[hieght, width];
            Min_Max m = new Min_Max();
            byte[] Array;

            if (T % 2 != 0)
            {
                Array = new byte[WS * WS];
            }
            else
            {
                Array = new byte[(WS + 1) * (WS + 1)];
            }
            
          
            for (int i = 0; i < hieght; i++)
            {
                for (int z =0 ; z < width; z++)
                {
                   

                    neighbour(Image, i, z, WS, Array);
                    if (sort == 1)
                    {
                        Counting coun = new Counting();
                        byte[] a = m.Mi(Array);
                        coun.CountingSort(Array, Array.Length, a[0], a[1]);
                        int q = 0;
                        int n = Array.Length - 1;
                           
                        while (q < T)
                        {
                           
                            Array = Array.Where(val => val != Array[q]).ToArray();
                            Array = Array.Where(val => val != Array[n]).ToArray();
                            q++;
                            n--;
                        }

                    }
                    else if(sort == 2)
                    {
                        int q = 0;
                        while (q < T)
                        {
                            byte[] n = m.Mi(Array);
                            Array = Array.Where(val => val != n[0]).ToArray();
                            Array = Array.Where(val => val != n[1]).ToArray();
                            q++;
                        }
                    }

                    Average O = new Average();
                    int av = O.aver(Array);
                    newimage[i, z] = (byte)av;

                }
            }
            return newimage;
        }
    }
}







       
 
    

