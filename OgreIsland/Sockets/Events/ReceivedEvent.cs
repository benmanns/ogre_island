using System;

namespace OgreIsland.Sockets.Events
{
    public class ReceivedEventArgs : EventArgs
    {
        public AbstractPacket Packet { get; protected set; }
        public ReceivedEventArgs(AbstractPacket packet) { Packet = packet; }
    }
    public delegate void ReceivedEventHandler(object sender, ReceivedEventArgs e);
}
