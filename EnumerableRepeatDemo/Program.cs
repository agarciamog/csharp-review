using System;
using System.Linq;

namespace EnumerableRepeatDemo
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] arr = Enumerable.Repeat(5, 10).ToArray();

			if(arr.Length == 10)
				Console.WriteLine(string.Join(", ", arr));
        }
    }
}
