namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Network
{
    public class NetLatencyManager : IReadable<NetLatencyManager>
    {
        public NetLatencyManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
