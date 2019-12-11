// https://csharpindepth.com/articles/singleton
using System;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
			Singleton s = Singleton.Instance;
			s.DoStuff();
        }
    }

	public sealed class  Singleton
	{
		private static readonly Singleton _instance = new Singleton();

		public static Singleton Instance
		{
			get => _instance;
		}

		public void DoStuff() =>
			Console.WriteLine("Do Stuff");
	}
}
