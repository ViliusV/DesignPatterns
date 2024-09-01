using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
	internal class PlayerContext
	{
		private IPlayerStrategy? strategy;
		public void SetStrategy(IPlayerStrategy strategy)
		{
			this.strategy = strategy;
		}
		public Task Play(string fileName)
		{
			return strategy?.Play(fileName) ?? Task.CompletedTask;
		}
	}
}
