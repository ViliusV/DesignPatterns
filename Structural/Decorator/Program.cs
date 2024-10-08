﻿using System;

namespace Decorator
{
	class Program
	{
		static void Main(string[] args)
		{

			var powerDrill = new PowerDrill();

			powerDrill.Recharge();
			powerDrill.Drill();
			powerDrill.Drill();

			Console.WriteLine("Adding a hammer extension.");
			var silencer = new HammerExtension();
			silencer.SetPowerDrill(powerDrill);
			silencer.Drill();
			silencer.Drill();

			Console.WriteLine("Adding an extended battery.");
			var extendedMag = new ExtendedBattery();
			extendedMag.SetPowerDrill(silencer);
			extendedMag.Recharge();
			extendedMag.Drill();
			extendedMag.Drill();
			extendedMag.Drill();
			extendedMag.Drill();
			extendedMag.Drill();
			extendedMag.Drill();
			extendedMag.Drill();
			extendedMag.Drill();

			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}
	}
}
