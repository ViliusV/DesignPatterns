using System;

namespace Singleton
{
	class Program
	{
		static void Main(string[] args)
		{
			var object1 = SingletonObject.GetInstance();
			Console.WriteLine($"Data of object 1: {object1.Data}");

			var object2 = SingletonObject.GetInstance();
			Console.WriteLine($"Data of object 2: {object2.Data}");
			Console.WriteLine($"Are objects equal? {object.Equals(object1, object2)}");
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}
	}
}
