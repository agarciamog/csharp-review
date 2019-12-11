using System;
using System.Linq;
using ExtensionsDemo.MyExtensions;

namespace ExtensionsDemo
{
	public class Program
	{
		public static void Main(string[] args)
		{
			string myString = "this is a string with words.";

			Console.WriteLine(myString.WordCount());
		}
	}
}
