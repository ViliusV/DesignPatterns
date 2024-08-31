using System;

namespace Facade
{
	class Program
	{
		static void Main(string[] args)
		{
			var facade = new ProductsFacade();

			foreach (var product in facade.GetProductListForAccount("John Smith"))
			{
				Console.WriteLine($"Product name: {product.Name}");
				Console.WriteLine($"Product price: {product.Price}");
			}
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();

		}
	}
}
