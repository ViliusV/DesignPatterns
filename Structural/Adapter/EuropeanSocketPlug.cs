using System;

namespace Adapter
{

	internal class EuropeanSocketPlug : ISocketPlug
    {
        private IEuropeanElectricSocket? europeanSocket;

        public void SelectSocket(IElectricSocket socket)
        {
            if (socket is not IEuropeanElectricSocket)
            {
                throw new ArgumentException("The European plug can only be connected to a European socket.");
            }
            europeanSocket = (IEuropeanElectricSocket)socket;
        }

        public void ConnectToSocket()
        {
            europeanSocket?.ConnectTwoPins();
        }
    }
}
