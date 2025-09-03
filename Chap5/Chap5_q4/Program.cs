using static System.Console;

namespace Chap5_q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("반복 횟수를 입력하세요. : ");
            String? input = ReadLine();

            int num = Int32.Parse(input);
            if (num <= 0)
            {
                WriteLine("0보다 같거나 작은 수는 사용할 수 없습니다.");
                return;
            }

            for (int i = 1; i <= num; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Write('*');
                }
                WriteLine();
            }
        }
    }
}
