namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Network
{
    public class NetSvrProperties : IReadable<NetSvrProperties>
    {
        public NetSvrProperties Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
