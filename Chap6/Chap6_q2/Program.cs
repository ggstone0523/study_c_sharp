﻿using System;

namespace Chap6_q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mean = 0;

            Mean(1, 2, 3, 4, 5, out mean);

            Console.WriteLine("평균 : {0}", mean);
        }
        public static void Mean(
            double a, double b, double c,
            double d, double e, out double mean
        )
        {
            mean = (a + b + c + d + e) / 5;
        }
    }
}
