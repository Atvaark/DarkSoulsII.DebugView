using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Managers.Network
{
    public class NetEnemyManager : IReadable<NetEnemyManager>
    {
        public NetEnemyManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
