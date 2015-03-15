﻿using DarkSoulsII.DebugView.Core.DarkSoulsII.GameObjects.GameEntities.Components;
using DarkSoulsII.DebugView.Core.Exceptions;
using DarkSoulsII.DebugView.Core.Rtti;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Rtti
{
    public class GameEntityComponentHelper : AbstractRttiResolver<GameEntityComponent>
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
