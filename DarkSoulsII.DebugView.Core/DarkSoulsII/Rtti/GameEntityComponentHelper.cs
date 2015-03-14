using DarkSoulsII.DebugView.Core.DarkSoulsII.GameObjects.GameEntities.Components;
using DarkSoulsII.DebugView.Core.Exceptions;
using DarkSoulsII.DebugView.Core.Rtti;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Rtti
{
    public class GameEntityComponentHelper : IRttiResolver<GameEntityComponent>
    {
        public IPointer<GameEntityComponent> ResolvePointer(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            // TODO: Create an abstract RttiResolver with a template method

            if (address == 0)
                return null;

            int vtable;
            try
            {
                vtable = reader.ReadInt32(address, relative);
            }
            catch (MemoryInaccessibleException)
            {
                return null;
            }

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
