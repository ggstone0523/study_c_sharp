using System;
using System.Collections;

namespace Chap10_q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht["Company"] = "Microsoft";
            ht["URL"] = "www.microsoft.com";

            Console.WriteLine("회사 : {0}", ht["Company"]);
            Console.WriteLine("URL : {0}", ht["URL"]);
        }
    }
}
