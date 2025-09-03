using System;
using static System.Console;

namespace Chap5_q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j >0; j--)
                {
                    Write("*");
                }
                WriteLine();
            }
        }
    }
}
