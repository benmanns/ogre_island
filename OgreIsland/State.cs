namespace OgreIsland
{
    public class State
    {
        public byte[] Buffer { get; set; }
        public System.Net.Sockets.Socket Socket { get; set; }
        public PacketList PacketList { get; set; }
        public State() { }
        public State(System.Net.Sockets.Socket socket, byte[] buffer) { Socket = socket; Buffer = buffer; }
        public State(System.Net.Sockets.Socket socket, PacketList packetList) { Socket = socket; PacketList = packetList; }
        public State(System.Net.Sockets.Socket socket) { Socket = socket; }
    }
}
