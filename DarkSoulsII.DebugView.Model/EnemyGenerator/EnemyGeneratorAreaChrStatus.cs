using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.EnemyGenerator
{
    public class EnemyGeneratorAreaChrStatus : IReadable<EnemyGeneratorAreaChrStatus>
    {
        public EnemyGeneratorAreaChrStatus Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}