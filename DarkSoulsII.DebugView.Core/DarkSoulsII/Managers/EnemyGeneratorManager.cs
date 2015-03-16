namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers
{
    public class EnemyGeneratorManager : IReadable<EnemyGeneratorManager>
    {
        public EnemyGeneratorManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}