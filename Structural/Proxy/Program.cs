using System;
using System.Threading.Tasks;

namespace Proxy
{
	class Program
	{
		static async Task Main(string[] args)
		{
			var dataService = new DataServiceProxy();

			dataService.InsertData("item1");
			dataService.InsertData("item2");
			dataService.InsertData("item3");

			var data = await dataService.GetData();

			Console.WriteLine($"Items retrieved: {data.Count}");
			data = await dataService.GetData();
			Console.WriteLine($"Items retrieved: {data.Count}");
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}
	}
}
