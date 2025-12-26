using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level3
{
    internal class MatrixCalculation
    {
        
        static int[,] BuildMatrix(int r, int c)							//build a matrix with random integers
        {
            int[,] mat = new int[r, c];
            Random rand = new Random();

            for(int i = 0; i < r; i++)
                for(int j = 0; j < c; j++)
                    mat[i, j] = rand.Next(1, 10);

            return mat;
        }
        static int[,] SumMatrix(int[,] x, int[,] y)						//add two matrices
        {
            int r = x.GetLength(0);
            int c = x.GetLength(1);
            int[,] res = new int[r, c];

            for(int i = 0; i < r; i++)
                for(int j = 0; j < c; j++)
                    res[i, j] = x[i, j] + y[i, j];

            return res;
        }
        static int[,] DiffMatrix(int[,] x, int[,] y)						//subtract two matrices
        {
            int r = x.GetLength(0);
            int c = x.GetLength(1);
            int[,] res = new int[r, c];

            for(int i = 0; i < r; i++)
                for(int j = 0; j < c; j++)
                    res[i, j] = x[i, j] - y[i, j];

            return res;
        }
        static int[,] ProductMatrix(int[,] x, int[,] y)						 //multiply two matrices
        {
            int r = x.GetLength(0);
            int n = x.GetLength(1);
            int c = y.GetLength(1);

            int[,] res = new int[r, c];

            for(int i = 0; i < r; i++)
                for(int j = 0; j < c; j++)
                    for(int k = 0; k < n; k++)
                        res[i, j] += x[i, k] * y[k, j];

            return res;
        }
        static int[,] FlipMatrix(int[,] m)							//transpose a matrix
        {
            int r = m.GetLength(0);
            int c = m.GetLength(1);
            int[,] t = new int[c, r];

            for(int i = 0; i < r; i++)
                for(int j = 0; j < c; j++)
                    t[j, i] = m[i, j];

            return t;
        }
        static int Det2(int[,] m)								//calculate determinant of 2x2 matrix
        {
            return (m[0, 0] * m[1, 1]) - (m[0, 1] * m[1, 0]);
        }
        static int Det3(int[,] m)								//calculate determinant of 3x3 matrix
        {
            return
                m[0, 0] * (m[1, 1] * m[2, 2] - m[1, 2] * m[2, 1]) -
                m[0, 1] * (m[1, 0] * m[2, 2] - m[1, 2] * m[2, 0]) +
                m[0, 2] * (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]);
        }
        static double[,] Inverse2(int[,] m)							 // calculate inverse of 2x2 matrix
        {
            double d = Det2(m);
            if(d == 0) return null;

            double[,] inv = new double[2, 2];

            inv[0, 0] = m[1, 1] / d;
            inv[0, 1] = -m[0, 1] / d;
            inv[1, 0] = -m[1, 0] / d;
            inv[1, 1] = m[0, 0] / d;

            return inv;
        }
        static double[,] Inverse3(int[,] m)					    		// calculate inverse of 3x3 matrix
        {
            double d = Det3(m);
            if(d == 0) return null;

            double[,] inv = new double[3, 3];

            inv[0, 0] = (m[1, 1] * m[2, 2] - m[1, 2] * m[2, 1]) / d;
            inv[0, 1] = (m[0, 2] * m[2, 1] - m[0, 1] * m[2, 2]) / d;
            inv[0, 2] = (m[0, 1] * m[1, 2] - m[0, 2] * m[1, 1]) / d;

            inv[1, 0] = (m[1, 2] * m[2, 0] - m[1, 0] * m[2, 2]) / d;
            inv[1, 1] = (m[0, 0] * m[2, 2] - m[0, 2] * m[2, 0]) / d;
            inv[1, 2] = (m[0, 2] * m[1, 0] - m[0, 0] * m[1, 2]) / d;

            inv[2, 0] = (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]) / d;
            inv[2, 1] = (m[0, 1] * m[2, 0] - m[0, 0] * m[2, 1]) / d;
            inv[2, 2] = (m[0, 0] * m[1, 1] - m[0, 1] * m[1, 0]) / d;

            return inv;
        }
        static void Show(int[,] m)								//display matrix
        {
            for(int i = 0; i < m.GetLength(0); i++)
            {
                for(int j = 0; j < m.GetLength(1); j++)
                    Console.Write(m[i, j] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Show(double[,] m)								//display matrix
        {
            for(int i = 0; i < m.GetLength(0); i++)
            {
                for(int j = 0; j < m.GetLength(1); j++)
                    Console.Write(Math.Round(m[i, j], 2) + "\t");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
	 static void Main(string[] args)
        {
            int[,] X = BuildMatrix(3, 3);							//Build two 3x3 matrices
            int[,] Y = BuildMatrix(3, 3);

            Console.WriteLine("Matrix X");
            Show(X);

            Console.WriteLine("Matrix Y");
            Show(Y);

            Console.WriteLine("X + Y");
            Show(SumMatrix(X, Y));

            Console.WriteLine("X - Y");
            Show(DiffMatrix(X, Y));

            Console.WriteLine("X * Y");
            Show(ProductMatrix(X, Y));

            Console.WriteLine("Transpose of X");
            Show(FlipMatrix(X));

            Console.WriteLine("Determinant (3x3): " + Det3(X));

            double[,] inv = Inverse3(X);
            if(inv != null)
            {
                Console.WriteLine("Inverse of X");
                Show(inv);
            }
            else
            {
                Console.WriteLine("Inverse not possible");
            }
        }
    }
}
