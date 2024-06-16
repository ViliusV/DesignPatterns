using System.Threading.Tasks;

namespace AbstractFactory
{
	internal abstract class PlayButton
	{
		public abstract Task Play(string fileName);
	}
}
