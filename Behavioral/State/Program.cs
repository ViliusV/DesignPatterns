namespace State
{
	internal class Program
	{
		static void Main(string[] args)
		{
            var phone = new MobilePhoneContext();


            phone.PressHomeButton();
            var apps = phone.GetAppNames();

            foreach (var app in apps)
            {
                phone.SelectApp(app);
                phone.GetCurrentApp();
            }

            Console.WriteLine("Changing the phone state to unlocked.");
            phone.ChangeState(new UnlockedScreenState());

            phone.PressHomeButton();
            apps = phone.GetAppNames();

            foreach (var app in apps)
            {
                phone.SelectApp(app);
                phone.GetCurrentApp();
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
	}
}
