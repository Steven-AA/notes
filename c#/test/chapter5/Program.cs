using System;

namespace chapter5
{
    //virtual class a{}
    public abstract class A
    {
        public abstract void F();
        public void f()
        {
            Console.WriteLine("A.f");
        }
        public virtual void G()
        {
            Console.WriteLine("A.G");
        }
        public virtual void g()
        {
            Console.WriteLine("A.g");
        }
    }
    public class B:A
    {
        public override void F()
        {
            Console.WriteLine("B.F");
        }
        public void f()
        {
            Console.WriteLine("B.f");
        }
        public sealed override void G()
        {
            Console.WriteLine("B.G");
        }
        public override void g()
        {
            Console.WriteLine("B.g");
        }
    }
    public class C:A
    {
        public override void F()
        {
            Console.WriteLine("C.F");
        }
    }
    public class D:B
    {
        public override void F()
        {
            Console.WriteLine("D.F");
        }
        public void f()
        {
            Console.WriteLine("D.f");
        }
        // public void G()
        // {
        //     Console.WriteLine("D.G");
        // }
        public override void g()
        {
            Console.WriteLine("D.g");
        }
    }
    class E:D
    {
        int a;
    }
    class Program
    {
        static void Main(string[] args)
        {
            B B = new B();
            C C = new C();
            D D = new D();
            E E = new E();
            Console.WriteLine("B:");
            B.F();
            B.f();
            B.G();
            B.g();
            Console.WriteLine("C:");
            C.F();
            C.f();
            C.G();
            C.g();
            Console.WriteLine("D:");
            D.F();
            D.f();
            D.G();
            D.g();
            E.G();
        }
    }
}
