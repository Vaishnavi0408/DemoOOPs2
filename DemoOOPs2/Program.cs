using System;

namespace DemoOOps2
{

    class Parent
    {
        int a, b;

        public Parent(int a,int b)
        {
            this.a = a;
            this.b = b;
        }

        public int B { get => b; set => b = value; }
        public int A { get => a; set => a = value; }



        public void Greet()
        {
            Console.WriteLine("Good Morning");
        }

        public virtual void Study()
        {
            Console.WriteLine("Read Book");
        }

        public override string ToString()
        {
            return $"a={a} b={b}";
        }
    }

    class Child : Parent
    {
        public Child(int x, int y):base(x, y)
        {
           // Console.WriteLine();          
        }
        public override void Study()
        {
            Console.WriteLine("Learning online");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child(11, 12);
            c.Greet();
            c.Study();

            Parent p= new Parent(11,10);
            Console.WriteLine(p);
            p.Study();

        }
    }
}