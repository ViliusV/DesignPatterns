using System.Threading.Tasks;

namespace AbstractFactory
{
	internal class WindowsPlayButton : PlayButton
    {
        public override Task Play(string fileName)
        {
            WindowsPlayerUtility.ExecuteMciCommand($"Play {fileName}");
            return Task.CompletedTask;
        }
    }
}
