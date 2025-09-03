using System;
using static System.Console;

namespace Chap5_q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j = 0;

            while (i <= 5)
            {
                j = i;
                while (j > 0)
                {
                    Write('*');
                    j--;
                }
                WriteLine();
                i++;
            }

            WriteLine();

            i = 5;
            while (i > 0)
            {
                j = 0;
                while (j < i)
                {
                    Write('*');
                    j++;
                }
                WriteLine();
                i--;
            }

            WriteLine();

            i = 1;
            do
            {
                j = 0;
                do
                {
                    Write("*");
                    j++;
                } while (j < i);
                WriteLine();
                i++;
            } while (i <= 5);

            WriteLine();

            i = 5;
            do
            {
                j = 0;
                do
                {
                    Write("*");
                    j++;
                } while (j < i);
                WriteLine();
                i--;
            } while (i > 0); 
        }
    }
}
