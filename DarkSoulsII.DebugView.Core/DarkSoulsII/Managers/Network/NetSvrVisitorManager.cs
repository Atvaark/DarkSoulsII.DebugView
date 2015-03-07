namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Network
{
    public class NetSvrVisitorManager : IReadable<NetSvrVisitorManager>
    {
        public NetSvrVisitorManager Read(IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
