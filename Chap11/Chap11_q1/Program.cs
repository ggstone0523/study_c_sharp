using System;
using System.Reflection.Metadata.Ecma335;

namespace Chap11_q1
{
    class StructArray<T> where T : struct
    {
        public T[] Array { get; set; }
        public StructArray(int size)
        {
            Array = new T[size];
        }
    }
    class RefArray<T> where T : class
    {
        public T[] Array { get; set; }
        public RefArray(int size)
        {
            Array = new T[size];
        }
    }
    class Base { }
    class Derived : Base { }
    class BaseArray<U> where U : Base
    {
        public U[] Array{ get; set; }
        public BaseArray(int size)
        {
            Array = new U[size];
        }
        public void CopyArray<T>(T[] Source) where T : U
        {
            Source.CopyTo(Array, 0);
        }
    }

    interface IBase 
    {
        void PrintMyType();
    }
    class IDerived : IBase
    {
        public void PrintMyType()
        {
            Console.WriteLine("My type is {0}", this.GetType());
        }
    }
    class IBaseArray<U> where U : IBase
    {
        public U[] Array { get; set; }
        public IBaseArray(int size)
        {
            Array = new U[size];
        }
    }
    internal class Program
    {
        public static T CreateInstance<T>() where T : new()
        {
            return new T();
        }
        static void Main(string[] args)
        {
            StructArray<int> a = new StructArray<int>(3);
            a.Array[0] = 0;
            a.Array[1] = 1;
            a.Array[2] = 2;
            Console.WriteLine("Type of a: {0}\nType of a.Array: {1}\n", a.GetType(), a.Array.GetType());

            RefArray<StructArray<double>> b = new RefArray<StructArray<double>>(3);
            b.Array[0] = new StructArray<double>(5);
            b.Array[1] = new StructArray<double>(10);
            b.Array[2] = new StructArray<double>(1005);
            Console.WriteLine("Type of b: {0}\nType of b.Array: {1}\n", b.GetType(), b.Array.GetType());

            BaseArray<Base> c = new BaseArray<Base>(3);
            c.Array[0] = new Base();
            c.Array[1] = new Derived();
            c.Array[2] = CreateInstance<Base>();
            Console.WriteLine("Type of c: {0}\nType of c.Array: {1}\n", c.GetType(), c.Array.GetType());

            BaseArray<Derived> d = new BaseArray<Derived>(3);
            d.Array[0] = new Derived();
            d.Array[1] = CreateInstance<Derived>();
            d.Array[2] = CreateInstance<Derived>();
            Console.WriteLine("Type of d: {0}\nType of d.Array: {1}\n", d.GetType(), d.Array.GetType());

            BaseArray<Derived> e = new BaseArray<Derived>(3);
            e.CopyArray<Derived>(d.Array);
            Console.WriteLine("Type of e: {0}\nType of e.Array: {1}\n", e.GetType(), e.Array.GetType());

            IBaseArray<IDerived> f = new IBaseArray<IDerived>(3);
            f.Array[0] = new IDerived();
            f.Array[1] = new IDerived();
            f.Array[2] = CreateInstance<IDerived>();
            Console.WriteLine("Type of f: {0}\nType of f.Array: {1}", f.GetType(), f.Array.GetType());
            f.Array[0].PrintMyType();
            f.Array[2].PrintMyType();
        }
    }
}
