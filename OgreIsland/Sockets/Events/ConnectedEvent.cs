using System;

namespace OgreIsland.Sockets.Events
{
    public class ConnectedEventArgs : EventArgs { }
    public delegate void ConnectedEventHandler(object sender, ConnectedEventArgs e);
}
