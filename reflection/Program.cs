using System;
using System.Reflection;

namespace reflection
{
	class Program
	{
		static void Main(string[] args)
		{
			Person p1 = new Person(34, "Alberto Garcia");
			p1.WhoAmI();

			Type type = p1.GetType();
			Console.WriteLine(type);

			Attribute[] attr = Attribute.GetCustomAttributes(type);

			foreach(Attribute att in attr)
			{
				Console.WriteLine(att);
				if(att.ToString() == "reflection.Version")
					Console.WriteLine(((Version)att).VerNum.ToString("f1"));
			}

			MethodInfo[] methods = type.GetMethods();
			foreach(MethodInfo m in methods)
				Console.WriteLine(m);
		}
	}

	[Serializable(), Version(2.0)]
	public class Person
	{
		int age;
		string name;

		public Person(int a, string n)
		{
			age = a;
			name = n;
		}

		public void WhoAmI() => Console.WriteLine("{0}, {1}", name, age);
	}

	public class Version : Attribute
	{
		private double _verNum;

		public double VerNum
		{
			get { return _verNum; }
			set { _verNum = value; }
		}

		public Version(double verNum = 1.0) => VerNum = verNum;

		public string GetName() => "Version";
	}
}
