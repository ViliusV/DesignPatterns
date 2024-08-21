using System;

namespace Adapter
{
	class Program
	{
		static void Main(string[] args)
		{
			var socketPlug = new EuropeanSocketPlug();
			socketPlug.SelectSocket(new EuropeanElectricSocket());
			socketPlug.ConnectToSocket();

			var adapter = new SocketAdapter();

			adapter.SelectSocket(new BritishElectricSocket());
			adapter.ConnectToSocket();

			socketPlug.SelectSocket(adapter);
			socketPlug.ConnectToSocket();
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}
	}
}
