namespace Adapter
{
	internal interface ISocketPlug
    {
        void SelectSocket(IElectricSocket socket);
        void ConnectToSocket();
    }
}
