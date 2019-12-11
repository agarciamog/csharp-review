using System;

namespace refOut
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Person p1 = new Person("Joe", 20);
			Person p2 = new Person("Dude", 50);

			Change(p1);

			Console.WriteLine($"{p1.name}, {p1.age}");

			int num = 5;
			ChangeNum(ref num);
			Console.WriteLine(num);
		}

		static void Change(Person p)
		{
			p.age += 1;
			p.name = "Diff";

			p = new Person("Way Diff", 100);
		}

		static void ChangeNum(ref int n) => n = 10;
	}

	public class Person
	{
		public string name { get; set; }
		public int age { get; set; }

		public Person(string name, int age)
		{
			this.name = name;
			this.age = age;
		}
	}
}
