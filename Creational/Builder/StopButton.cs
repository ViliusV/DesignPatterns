using System.Threading.Tasks;

namespace Builder
{
	internal abstract class StopButton
	{
		public abstract Task Stop(string fileName);
	}
}
