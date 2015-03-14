namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Network
{
    public class NetPlayerSyncObject : IReadable<NetPlayerSyncObject>
    {
        public NetPlayerSyncObject Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
