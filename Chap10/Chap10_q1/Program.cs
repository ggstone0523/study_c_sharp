using System;

namespace Chap10_q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] twoDArray = new int[2, 3] { { 0, 1, 2 }, { 3, 4, 5 } };
            foreach (int num in twoDArray)
            {
                Console.WriteLine(num);
            }
        }
    }
}
