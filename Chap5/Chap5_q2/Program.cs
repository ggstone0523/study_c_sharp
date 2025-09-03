using System;
using static System.Console;

namespace Chap5_q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 5; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Write('*');
                }
                WriteLine();
            }
        }
    }
}
