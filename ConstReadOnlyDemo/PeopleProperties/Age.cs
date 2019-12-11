using System;

namespace ConstReadOnlyDemo.PeopleProp
{
	public class Age
	{
		private readonly int _age;

		public int AgeProp { get; }

		public Age(int age)
		{
			_age = age;
		}
	}
}
