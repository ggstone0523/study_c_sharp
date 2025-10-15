using System;

namespace Chap12_q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            for (int i = 0; i < 10; ++i)
                arr[i] = i;

            try
            {
                for (int i = 0; i < 11; ++i)
                    Console.WriteLine(arr[i]);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Range Exception Occur!");
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
