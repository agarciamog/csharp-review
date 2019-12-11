using System;
using System.Linq;

namespace CopyCloneDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] arr1 = {1,2,3,4};
			int[] arr2 = (int[])arr1.Clone();

			arr1[0] = 99;

			// arr2.ToList().ForEach(i => Console.WriteLine(i.ToString());

			Console.WriteLine(string.Join(", ", arr2));

			Array.ForEach(arr2, Console.WriteLine);
			*/

			Person p1 = new Person("Alberto");
			Person p2 = new Person("Cinthia");

			Person[] people = { new Person("Alberto"), new Person("Cinthia") };
			
			Person[] peopleClone = (Person[]) people.Clone();

			peopleClone[0].Name = "Bill";

			Console.WriteLine(string.Join<Person>(", ", people)); 

			int[] arr1 = {1, 2, 3, 4};
			int[] arr2 = new int[4] {1, 2, 3, 0};

			arr1.CopyTo(arr2, 0);

			string output = "";
			foreach(var i in arr2)
				output += $" {i} ";

			Console.WriteLine(output);
        }	
    }
}
