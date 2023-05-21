using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixArrayFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            MA ma = new MA();
            int[,] A;
            Console.Write("Please Enter The Count Of Matrix : ");
            int N = int.Parse(Console.ReadLine());
            A = new int[N, N];
            ma.BuildMatrix(A, N);
            Console.WriteLine("\nMatrix Is : ");
            ma.PrintMatrix(A, N);

            Console.WriteLine("\n\nAbove Main Diameter Element Is : ");
            int A1 = ma.AvgAboveMainDiameter(A, N);
            Console.WriteLine("Average Of Elements Is : " + A1);
            ma.MaxMinAboveMainDiameter(A, N);

            Console.WriteLine("\n\nBottom Main Diameter Element Is : ");
            int A2 = ma.AvgBottomMainDiameter(A, N);
            Console.WriteLine("Average Of Elements Is : " + A2);
            ma.MaxMinBottomMainDiameter(A, N);

            Console.WriteLine("\n\nAbove Sub Diameter Element Is : ");
            int A3 = ma.AvgAboveSubDiameter(A, N);
            Console.WriteLine("Average Of Elements Is : " + A3);
            ma.MaxMinAboveSubDiameter(A, N);

            Console.WriteLine("\n\nBottom Sub Diameter Element Is : ");
            int A4 = ma.AvgBottomSubDiameter(A, N);
            Console.WriteLine("Average Of Elements Is : " + A4);
            ma.MaxMinBottomSubDiameter(A, N);

            Console.ReadKey();
        }
    }
}
