using DarkSoulsII.DebugView.Core.DarkSoulsII.Network;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Network
{
    public class NetSessionManager : IReadable<NetSessionManager>
    {
        public ServerInfo ServerInfo { get; set; }
        public NetLatencyManager LatencyManager { get; set; }

        public NetSessionManager Read(IReader reader, int address, bool relative = false)
        {
            ServerInfo = Pointer<ServerInfo>.Create(address + 0x002C).Unbox(reader);
            LatencyManager = Pointer<NetLatencyManager>.CreateAndUnbox(reader, address + 0x005C);
            return this;
        }
    }
}
