using System;
using System.Numerics;

namespace Chap8_q1
{
    interface IRunnable
    {
        void Run();
    }
    interface IFlyable
    {
        void Fly();
    }
    class Plane : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Fly");
        }
        public void Ride()
        {
            Fly();
        }
    }
    class Car : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("Run");
        }
        public void Ride()
        {
            Run();
        }
    }
    class FlyingCar : IRunnable, IFlyable
    {
        public void Run()
        {
            Console.WriteLine("Run! Run!");
        }
        public void Fly()
        {
            Console.WriteLine("Fly! Fly!");
        }
    }
    class Answer1 : FlyingCar
    {
    }
    class Answer2
    {
        Car car = new Car();
        Plane plane  = new Plane();

        public void Run()
        {
            car.Ride();
        }
        public void Fly()
        {
            plane.Ride();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Answer1 answer1 = new Answer1();
            answer1.Run();
            answer1.Fly();

            Answer2 answer2 = new Answer2();
            answer2.Run();
            answer2.Fly();
        }
    }
}
