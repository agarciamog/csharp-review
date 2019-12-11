using System;
using ConstReadOnlyDemo.PeopleProp;

namespace ConstReadOnlyDemo
{
	public class Program
	{
		public static void Main(string[] args)
		{
			const int constVar = 5;
			Age prop = new Age(34);

			Console.WriteLine($"{constVar}");

			prop.AgeProp = 20; // Compilation Error
		}
	}
}
