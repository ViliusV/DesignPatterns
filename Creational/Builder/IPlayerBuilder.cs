namespace Builder
{
	internal interface IPlayerBuilder
	{
		void AddPlayButton();
		void AddStopButton();
		Player BuildPlayer();
	}
}
