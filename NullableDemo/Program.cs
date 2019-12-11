using System;

namespace NullableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
			int? n = null;

			if(n.HasValue)
				Console.WriteLine(n);
        }
    }
}
