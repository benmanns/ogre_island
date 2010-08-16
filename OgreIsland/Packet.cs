namespace OgreIsland
{
    public class Packet
    {
        public string Command { get; set; }
        public string[] Arguments { get; set; }
        public Packet(string command, string[] arguments) { Command = command; Arguments = arguments; }
    }
}
