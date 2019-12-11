using System;

namespace OverridingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
			ClassB B = new ClassB();
			B.X();
        }
    }
}
