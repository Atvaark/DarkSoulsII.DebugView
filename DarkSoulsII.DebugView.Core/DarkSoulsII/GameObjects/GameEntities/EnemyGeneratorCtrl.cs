namespace DarkSoulsII.DebugView.Core.DarkSoulsII.GameObjects.GameEntities
{
    public class EnemyGeneratorCtrl : GameEntity, IReadable<EnemyGeneratorCtrl>
    {
        public new EnemyGeneratorCtrl Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}