using System;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;

namespace Chap16_q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object myObject = new int();

            Type t1 = myObject.GetType();
            //Type t2 = typeof("int"); => error!
            //Type t3 = Type.GetType(int); => error!
            Type t4 = Type.GetType("System.Int32");

            Console.WriteLine(t1);
            Console.WriteLine(t4);
        }
    }
}
