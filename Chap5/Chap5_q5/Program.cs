using static System.Console;

namespace Chap5_q5
{
    internal class Program
    {
        public static long GetNumber(long index)
        {
            long result = index switch
            {
                0 => 0,
                1 => 1,
                _ => GetNumber(index - 1) + GetNumber(index - 2)
            };

            return result;
        }
        static void Main(string[] args)
        {
            WriteLine($"Answer: {GetNumber(5)}");
        }
    }
}
