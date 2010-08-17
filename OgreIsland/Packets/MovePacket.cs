using System;

namespace OgreIsland.Packets
{
    public class MovePacket : AbstractPacket
    {
        public MovePacket(Mode mode) : base(new Packet("MOVE", new string[mode == Mode.Client ? 3 : 4]), mode) { }
        public MovePacket(Packet packet, Mode mode) : base(packet, mode) { }
        public new Mode Mode { get { return base.Mode; } set { base.Mode = value; } }
        public string Id
        {
            get
            {
                switch (Mode)
                {
                    case Mode.Client: throw new ArgumentOutOfRangeException();
                    case Mode.Server: return Arguments[0];
                    default: throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                switch (Mode)
                {
                    case Mode.Client: throw new ArgumentOutOfRangeException();
                    case Mode.Server:
                        {
                            Arguments[0] = value;
                            break;
                        }
                    default: throw new ArgumentOutOfRangeException();
                }
            }
        }
        public string X
        {
            get
            {
                switch (Mode)
                {
                    case Mode.Client: return Arguments[0];
                    case Mode.Server: return Arguments[1];
                    default: throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                switch (Mode)
                {
                    case Mode.Client:
                        {
                            Arguments[0] = value;
                            break;
                        }
                    case Mode.Server:
                        {
                            Arguments[1] = value;
                            break;
                        }
                    default: throw new ArgumentOutOfRangeException();
                }
            }
        }
        public string Y
        {
            get
            {
                switch (Mode)
                {
                    case Mode.Client: return Arguments[1];
                    case Mode.Server: return Arguments[2];
                    default: throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                switch (Mode)
                {
                    case Mode.Client:
                        {
                            Arguments[1] = value;
                            break;
                        }
                    case Mode.Server:
                        {
                            Arguments[2] = value;
                            break;
                        }
                    default: throw new ArgumentOutOfRangeException();
                }
            }
        }
        public string Tile
        {
            get
            {
                switch (Mode)
                {
                    case Mode.Client: return Arguments[2];
                    case Mode.Server: throw new ArgumentOutOfRangeException();
                    default: throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                switch (Mode)
                {
                    case Mode.Client:
                        {
                            Arguments[2] = value;
                            break;
                        }
                    case Mode.Server: throw new ArgumentOutOfRangeException();
                    default: throw new ArgumentOutOfRangeException();
                }
            }
        }
        public string Warp
        {
            get
            {
                switch (Mode)
                {
                    case Mode.Client: throw new ArgumentOutOfRangeException();
                    case Mode.Server: return Arguments[3];
                    default: throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                switch (Mode)
                {
                    case Mode.Client: throw new ArgumentOutOfRangeException();
                    case Mode.Server:
                        {
                            Arguments[3] = value;
                            break;
                        }
                    default: throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}
