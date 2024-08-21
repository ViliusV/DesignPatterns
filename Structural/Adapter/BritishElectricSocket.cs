using System;

namespace Adapter
{
	internal class BritishElectricSocket : IBritishElectricSocket
    {
        public void ConnectThreePins()
        {
            Console.WriteLine("Triple-pin plug has been successfully connected.");
        }
    }
}
