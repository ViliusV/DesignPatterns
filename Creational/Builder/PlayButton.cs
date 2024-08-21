using System.Threading.Tasks;

namespace Builder
{
	internal abstract class PlayButton
	{
		public abstract Task Play(string fileName);
	}
}
