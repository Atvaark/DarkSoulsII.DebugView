using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.GameObjects.GameEntities.Components
{
    public class GameEntityComponent : IReadable<GameEntityComponent>
    {
        public GameEntityComponent Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
