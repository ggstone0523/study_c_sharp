using System;

namespace Chap3_q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("int a = 7.3은 int 형식의 변수에 부동소수점 형식의 값을 넣으려고 하여 소수점 이하 값에 대한 손실이 발생함.");
            Console.WriteLine("char d = \"abc\"는 문자 형식의 변수에 문자열을 넣으려고 하여 에러가 발생함.");
            Console.WriteLine("stirng e = '한'은 문자열 형식의 변수에 문자를 넣으려고 하여 에러가 발생함.");
        }
    }
}
