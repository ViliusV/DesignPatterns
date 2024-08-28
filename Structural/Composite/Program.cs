using System;

namespace Composite
{
	class Program
	{
		static void Main(string[] args)
		{
			var rootFolder = new Folder("Root");
			rootFolder.Add(new Folder("Folder1"));
			rootFolder.Add(new Folder("Folder2"));

			var complexFolder = new Folder("Folder3");
			complexFolder.Add(new Folder("Folder4"));
			complexFolder.Add(new File("NewFile.xml"));
			complexFolder.Add(new File("NewFile2.xml"));
			rootFolder.Add(complexFolder);
			rootFolder.DisplayChildren(string.Empty);
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}
	}
}
