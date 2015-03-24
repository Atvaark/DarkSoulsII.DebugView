using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.GameObjects.GameEntities.Components;

namespace DarkSoulsII.DebugView.Model.Rtti
{
    public class GameEntityComponentResolver : AbstractRttiResolver<GameEntityComponent>
    {
        protected override IPointer<GameEntityComponent> ResolvePointerTransitive(IPointerFactory pointerFactory, int address, bool relative, int vtable)
        {
            // TODO: Implement switch statement
            IPointer<GameEntityComponent> pointer;
            switch (vtable)
            {
                case 0x00000000:
                    pointer = pointerFactory.Create<GameEntityComponent>(address, relative, true);
                    break;
                default:
                    pointer = null;
                    break;
            }
            return pointer;
        }
    }
}
