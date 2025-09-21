using System;

namespace Chap7_q2
{
    struct ACSetting
    {
        public double currentInCelsius;
        public double target;
        public readonly double GetFahrenheit()
        {
            return currentInCelsius * 1.8 + 32;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ACSetting acs;
            acs.currentInCelsius = 25;
            acs.target = 25;

            Console.WriteLine($"{acs.GetFahrenheit()}");
            Console.WriteLine($"{acs.target}");
        }
    }
}
