using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
			C obj = new C();
			obj.M();
			
			IA objA = new C();
			objA.M();
        }
    }

    interface IA
    {
		void M();
	}

	interface IB
	{
		string M();
	}

	class C : IA, IB
	{
		public void M()
		{
			Console.WriteLine("Hello from C.M()");	
		}
	}
}
