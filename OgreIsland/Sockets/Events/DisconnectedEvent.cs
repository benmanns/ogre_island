using System;

namespace OgreIsland.Sockets.Events
{
    public class DisconnectedEventArgs : EventArgs { }
    public delegate void DisconnectedEventHandler(object sender, DisconnectedEventArgs e);
}
