using System;
using MyAssembly;

namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {
			MessageWriter mw = new MessageWriter();
			mw.Print("Hello, World!");
            Console.WriteLine("Hello World!");
        }
    }
}
