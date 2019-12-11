using System;

namespace SealedDemo
{
	public sealed class ClassB : ClassA
	{
		public void Y() => Console.WriteLine("ClassB.Y()");
	}
}
