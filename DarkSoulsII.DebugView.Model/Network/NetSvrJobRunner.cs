using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Network
{
    public class NetSvrJobRunner : IReadable<NetSvrJobRunner>
    {
        public NetSvrJobRunner Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
