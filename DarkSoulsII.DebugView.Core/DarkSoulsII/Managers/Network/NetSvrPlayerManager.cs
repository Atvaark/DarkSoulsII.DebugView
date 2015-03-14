namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Network
{
    public class NetSvrPlayerManager : IReadable<NetSvrPlayerManager>
    {
        public NetSvrPlayerManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
