using System;

namespace OgreIsland.Sockets.Events
{
    public class SentEventArgs : EventArgs
    {
        public AbstractPacket Packet { get; private set; }
        public SentEventArgs(AbstractPacket packet) { Packet = packet; }
    }
    public delegate void SentEventHandler(object sender, SentEventArgs e);
}
