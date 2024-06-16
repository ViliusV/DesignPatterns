using System;
using System.Runtime.InteropServices;

namespace AbstractFactory
{
	class Program
	{
		static void Main(string[] args)
		{
            PlayerCreator? playerFactory;

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                playerFactory = new WindowsPlayerCreator();
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                playerFactory = new LinuxPlayerCreator();
            else
                throw new Exception("Only Linux and Windows operating systems are supported.");

            Console.WriteLine("Please specify the path to the file to play.");

            var filePath = Console.ReadLine() ?? string.Empty;
            playerFactory.CreatePlayButton().Play(filePath);

            Console.WriteLine("Playing audio. Type 'stop' to stop it or 'exit' to exit the application.");

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "stop")
                    playerFactory.CreateStopButton().Stop(filePath);
                else if (command == "exit")
                    break;
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
	}
}
