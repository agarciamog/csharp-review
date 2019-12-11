using System;

namespace ReverseSortDemo
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] arr = { 1, 5, 4, 0, 9, 0, 2 };
			Array.Sort(arr);
			Array.Reverse(arr);

			Console.WriteLine(string.Join(", ", arr));
        }
    }
}
