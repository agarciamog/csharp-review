using System;

namespace MulticastDelegateDemo
{
	delegate void Del();
    class Program
    {
        static void Main(string[] args)
        {
			Del del = new Del(SayHello);
			del += new Del(SayHi);
			del += new Del(SayHola);
		
			del();
        }

		static void SayHello() => Console.WriteLine("Hello!");
		static void SayHi() => Console.WriteLine("Hi!");
		static void SayHola() => Console.WriteLine("Hola!");
    }
}
