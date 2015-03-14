namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Network
{
    public class NetSvrMemory : IReadable<NetSvrMemory>
    {
        public NetSvrMemory Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
