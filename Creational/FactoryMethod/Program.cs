using System;
using System.Runtime.InteropServices;

namespace FactoryMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			PlayerCreator playerFactory;

			if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
			{
				playerFactory = new WindowsPlayerCreator();
			}
			else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
			{
				playerFactory = new LinuxPlayerCreator();
			}
			else
			{
				throw new Exception("Only Linux and Windows operating systems are supported.");
			}

			Console.WriteLine("Please specify the path to the file to play");
			var filePath = Console.ReadLine() ?? string.Empty;
			playerFactory.CreatePlayer().Play(filePath);
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}
	}
}
