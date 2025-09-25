using System;

namespace Chap10_q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] A = new int[2, 2] { { 3, 2 }, { 1, 4 } };
            int[,] B = new int[2, 2] { { 9, 2 }, { 1, 7 } };

            int[,] C = new int[2, 2] { { 0, 0 }, { 0, 0 } };
            C[0, 0] = A[0, 0] * B[0, 0] + A[0, 1] * B[1, 0];
            C[0, 1] = A[0, 0] * B[0, 1] + A[0, 1] * B[1, 1];
            C[1, 0] = A[1, 0] * B[0, 0] + A[1, 1] * B[1, 0];
            C[1, 1] = A[1, 0] * B[0, 1] + A[1, 1] * B[1, 1];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("{0} ", C[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
