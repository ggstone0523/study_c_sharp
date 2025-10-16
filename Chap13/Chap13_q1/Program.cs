using System;

namespace Chap13_q1
{
    delegate int MyDelegate(int a, int b);
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDelegate Callback;
            Callback = delegate (int a, int b)
            {
                return a + b;
            };
            Console.WriteLine(Callback(3, 4));
            Callback = delegate (int a, int b)
            {
                return a - b;
            };
            Console.WriteLine(Callback(7, 5));
        }
    }
}
