using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Managers.Network
{
    public class NetSvrSummonSignManager : IReadable<NetSvrSummonSignManager>
    {
        public NetSvrSummonSignManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
