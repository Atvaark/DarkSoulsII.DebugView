using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Network
{
    public class ServerInfo : IReadable<ServerInfo>
    {
        public ServerInfo Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            //0004
            //0008
            return this;
        }
    }
}
