//Adaptive
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilters
{
    internal class ADAPTIVE
    {
        public byte adap(byte[,] ImageMatrix, int x, int y, int W , int Wmax, int Sort)
        {

            byte[] Array = new byte[W * W];
            int[] Dx = new int[W * W];
            int[] Dy = new int[W * W];
            int Index = 0;
            for (int _y = -(W / 2); _y <= (W / 2); _y++)
            {
                for (int _x = -(W / 2); _x <= (W / 2); _x++)
                {
                    Dx[Index] = _x;
                    Dy[Index] = _y;
                    Index++;
                }
            }
            byte Max, Min, Med, Z;
            int A1, A2, B1, B2, ArrayLength, NewY, NewX;
            Max = 0;
            Min = 255;
            ArrayLength = 0;
            Z = ImageMatrix[y, x];
            for (int i = 0; i < W * W; i++)
            {
                NewY = y + Dy[i];
                NewX = x + Dx[i];
                if (NewX >= 0 && NewX < ImageOperations.GetWidth(ImageMatrix) && NewY >= 0 && NewY <ImageOperations. GetHeight(ImageMatrix))
                {
                    Array[ArrayLength] = ImageMatrix[NewY, NewX];
                    if (Array[ArrayLength] > Max)
                        Max = Array[ArrayLength];
                    if (Array[ArrayLength] < Min)
                        Min = Array[ArrayLength];
                    ArrayLength++;
                }
            }
            if (Sort == 1)
            {
                Quick q = new Quick();
                byte [] m = q.QUICK_SORT(Array, 0, Array.Length - 1);
            } 
            else if (Sort == 2)
            {
                Counting count = new Counting();
                Min_Max m = new Min_Max();
                byte []o =m.Mi(Array);
                count.CountingSort(Array, Array.Length, o[0], o[1]);
            }
           

            Min = Array[0];
            Med = Array[ArrayLength / 2];
            A1 = Med - Min;
            A2 = Max - Med;
            if (A1 > 0 && A2 > 0)
            {
                B1 = Z - Min;
                B2 = Max - Z;
                if (B1 > 0 && B2 > 0)
                    return Z;
                else
                {
                    if (W + 2 < Wmax)
                        return adap(ImageMatrix, x, y, W + 2, Wmax, Sort);
                    else
                        return Med;
                }
            }
            else
            {
                return Med;
            }

        }
    }
}

      

    

