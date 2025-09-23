using System;

namespace Chap9_q1
{
    class NameCard
    {
        public int Age
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            NameCard MyCard = new NameCard();

            MyCard.Age = 24;
            MyCard.Name = "상현";

            Console.WriteLine("나이 : {0}", MyCard.Age);
            Console.WriteLine("이름 : {0}", MyCard.Name);
        }
    }
}
