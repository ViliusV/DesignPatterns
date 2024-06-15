using System.Threading.Tasks;

namespace FactoryMethod
{
	internal abstract class Player
	{
		public abstract Task Play(string fileName);
	}
}
