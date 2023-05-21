using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixArrayFunc
{
    class MA
    {
        public void BuildMatrix(int[,] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Matrix [{i},{j}] Is : ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void PrintMatrix(int[,] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Matrix [{i},{j}] Is : {a[i, j]}\n");
                }
            }
        }
        public int AvgAboveMainDiameter(int[,] a, int n)
        {
            int s = 0, c = 0;
            for (int i = 1; i < n; i=i+2)
            {
                for (int j = i + 1; j < n; j++)
                {
                    Console.Write($"Matrix [{i},{j}] Is : {a[i, j]}\n");
                    s += a[i, j];
                    c++;
                }
            }
            return s / c;
        }
        public void MaxMinAboveMainDiameter(int[,] a, int n)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i, j] < min)
                    {
                        min = a[i, j];
                    }
                }
            }
            Console.Write("Max : "+max+" , Min : "+min);
        }
        public int AvgBottomMainDiameter(int[,] a, int n)
        {
            int s = 0, c = 0;
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write($"Matrix [{i},{j}] Is : {a[i, j]}\n");
                    s += a[i, j];
                    c++;
                }
            }
            return s / c;
        }
        public void MaxMinBottomMainDiameter(int[,] a, int n)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                    }
                }
            }
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (a[i, j] < min)
                    {
                        min = a[i, j];
                    }
                }
            }
            Console.Write("Max : " + max + " , Min : " + min);
        }
        public int AvgAboveSubDiameter(int[,] a, int n)
        {
            int s = 0, c = 0;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < (n - i) - 1; j++)
                {
                    Console.Write($"Matrix [{i},{j}] Is : {a[i, j]}\n");
                    s += a[i, j];
                    c++;
                }
            }
            return s / c;
        }
        public void MaxMinAboveSubDiameter(int[,] a, int n)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < (n - i) - 1; j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                    }
                }
            }
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < (n - i) - 1; j++)
                {
                    if (a[i, j] < min)
                    {
                        min = a[i, j];
                    }
                }
            }
            Console.Write("Max : " + max + " , Min : " + min);
        }
        public int AvgBottomSubDiameter(int[,] a, int n)
        {
            int s = 0, c = 0;
            for (int i = 1; i < n; i++)
            {
                for (int j = (n - i); j < n; j++)
                {
                    Console.Write($"Matrix [{i},{j}] Is : {a[i, j]}\n");
                    s += a[i, j];
                    c++;
                }

            }
            return s / c;
        }
        public void MaxMinBottomSubDiameter(int[,] a, int n)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 1; i < n; i++)
            {
                for (int j = (n - i); j < n; j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                    }
                }
            }
            for (int i = 1; i < n; i++)
            {
                for (int j = (n - i); j < n; j++)
                {
                    if (a[i, j] < min)
                    {
                        min = a[i, j];
                    }
                }
            }
            Console.Write("Max : " + max + " , Min : " + min);
        }
    }
}
