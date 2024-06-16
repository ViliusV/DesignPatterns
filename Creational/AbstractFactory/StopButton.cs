using System.Threading.Tasks;

namespace AbstractFactory
{
	internal abstract class StopButton
	{
		public abstract Task Stop(string fileName);
	}
}
