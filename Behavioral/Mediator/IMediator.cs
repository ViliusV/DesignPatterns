namespace Mediator
{
	internal interface IMediator
    {
        void Register(string key, IParticipant participant);
        void SendCommand(string receiver, string sender, string command);
    }
}
