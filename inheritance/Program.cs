using System;
using System.ComponentModel.DataAnnotations;

namespace inheritance
{
    class A
    {
        public virtual void Display()
        {
            Console.WriteLine("in A");
        }
    }

    class B : A
    {
        public new virtual void Display()
        {
            Console.WriteLine("in B");
        }
    }

    class C : B
    {
        public override void Display()
        {
            Console.WriteLine("in C");
        }
    }

    class D : C
    {
        public new virtual void Display()
        {
            Console.WriteLine("in D");
        }
    }

    class E : D
    {
        public override void Display()
        {
            Console.WriteLine("in E");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new E();
            a.Display();     // in A

            D d = new E();
            d.Display();     // in E

            B b = new C();
            b.Display();     // in C

            A a1 = new B();
            a1.Display();    // in A

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
