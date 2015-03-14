namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Network
{
    public class NetEnemyManager : IReadable<NetEnemyManager>
    {
        public NetEnemyManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
