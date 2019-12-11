using System;
using System.Text;

namespace IsAsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello";

			Console.WriteLine($"str is a string: {str is string}");
			Console.WriteLine($"str is a StringBuilder: {str is StringBuilder}");

			object[] arr = { new object(), 5, "Hi" };
			string s;
			foreach(object o in arr) {
				s = o as string;

				if(s != null)
					Console.WriteLine(s);
				else
					Console.WriteLine("Is not a string");
			}
        }
    }
}
