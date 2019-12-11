using System;

namespace delegates
{
	class Rectangle
	{
		delegate void MathOp(int x, int y);

		void Area(int x, int y)
		{
			Console.WriteLine("Area: {0}", x*y);
		}

		void Perimeter(int x, int y)
		{
			Console.WriteLine("Perimeter: {0}", 2*x + 2*y);
		}

		static void Main(string[] args)
		{
			Rectangle rec = new Rectangle();
			MathOp op = rec.Area;
			op += rec.Perimeter;

			op(2, 4);
		}
	}
}
