using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class WindowsPlayerBuilder : IPlayerBuilder
    {
        private readonly Player player = new Player();

        public void AddPlayButton()
        {
            player.PlayButton = new WindowsPlayButton();
        }
        public void AddStopButton()
        {
            player.StopButton = new WindowsStopButton();
        }
        public Player BuildPlayer()
        {
            return player;
        }
    }
}
