using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Network
{
    public class NetPlayerSyncObject : IReadable<NetPlayerSyncObject>
    {
        public NetPlayerSyncObject Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
