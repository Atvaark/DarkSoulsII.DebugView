namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Network
{
    public class NetSvrBloodMessageManager : IReadable<NetSvrBloodMessageManager>
    {
        public NetSvrBloodMessageManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
