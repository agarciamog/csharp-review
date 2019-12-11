using System;
using System.Collections;

namespace ArrayListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
			ArrayList myAL = new ArrayList();
			myAL.Add("Hello");
			myAL.Add(1);

			for(int i = 0; i < myAL.Count; i++)
				Console.WriteLine(myAL[i].GetType());

            Console.WriteLine("Hello World!");
        }
    }
}
