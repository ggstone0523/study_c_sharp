using System;
using System.Reflection;

namespace Chap16_q1
{
    internal class Program
    {
        static void PrintMembers(Type type)
        {
            Console.WriteLine("-------- Members --------");

            MemberInfo[] members = type.GetMembers();
            foreach(MemberInfo i in members)
                Console.WriteLine(i.Name);

            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int a = 0;
            Type type = a.GetType();

            PrintMembers(type);
        }
    }
}
