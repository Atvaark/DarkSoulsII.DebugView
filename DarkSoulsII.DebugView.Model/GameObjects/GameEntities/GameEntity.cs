using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.GameObjects.GameEntities
{
    public class GameEntity : GameObject, IReadable<GameEntity>
    {
        public new GameEntity Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            // GameEntityComponent 0x000C
            return this;
        }
    }
}
