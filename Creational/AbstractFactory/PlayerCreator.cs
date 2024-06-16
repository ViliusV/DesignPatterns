namespace AbstractFactory
{
	internal abstract class PlayerCreator
	{
		public abstract PlayButton CreatePlayButton();
		public abstract StopButton CreateStopButton();
	}
}
