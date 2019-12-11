using System;

namespace OverloadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Overloaded obj = new Overloaded();

			obj.MyMethod();
			obj.MyMethod("bleh");
			Console.WriteLine(obj.MyMethod(1));
        }
    }
	
	public class Overloaded
	{
		public void MyMethod() {
			Console.WriteLine("void MyMethod()");
		}

		public void MyMethod(string str = "my string") {
			Console.WriteLine("void MyMethod(string str = \"my string\")");
		}

		public int MyMethod(int i) => i + 10;
	
	}
}
