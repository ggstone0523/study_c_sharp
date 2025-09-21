using System;
using MyExtension;

namespace MyExtension
{
    public static class StringExtension
    {
        public static string Append(this string MyStr, string AppendStr)
        {
            return MyStr + AppendStr;
        }
    }
}

namespace Chap7_q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            Console.WriteLine(hello.Append(", World!"));
        }
    }
}
