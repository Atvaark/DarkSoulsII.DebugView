namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Network
{
    public class NetSummonSlotCtrl : IReadable<NetSummonSlotCtrl>
    {
        public NetSummonSlotCtrl Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
