namespace AbstractFactory
{
	internal class LinuxPlayerCreator : PlayerCreator
    {
        public override PlayButton CreatePlayButton()
        {
            return new LinuxPlayButton();
        }
        public override StopButton CreateStopButton()
        {
            return new LinuxStopButton();
        }
    }
}
