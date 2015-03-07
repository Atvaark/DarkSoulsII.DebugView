namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Network
{
    public class NetSvrClientInterface : IReadable<NetSvrClientInterface>
    {
        public NetSvrClientInterface Read(IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
