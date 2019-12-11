using System;
using System.Linq;

namespace ExtensionsDemo.MyExtensions
{
	public static class WordExtensions
	{
		public static int WordCount(this string str)
		{
			return str.Split(" ").Length;
		}
	}
}
