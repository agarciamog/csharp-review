using System;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
        	MyClass obj = new MyClass();
			obj.A();
        }
    }

	interface MyInterface
	{
		void A();
	}

	public class MyClass : MyInterface
	{
		public void A() => Console.WriteLine("Hello from A");
	}
}
