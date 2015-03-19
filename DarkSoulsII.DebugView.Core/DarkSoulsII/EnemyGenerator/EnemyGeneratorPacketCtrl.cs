namespace DarkSoulsII.DebugView.Core.DarkSoulsII.EnemyGenerator
{
    public class EnemyGeneratorPacketCtrl : IReadable<EnemyGeneratorPacketCtrl>
    {
        public EnemyGeneratorPacketCtrl Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}