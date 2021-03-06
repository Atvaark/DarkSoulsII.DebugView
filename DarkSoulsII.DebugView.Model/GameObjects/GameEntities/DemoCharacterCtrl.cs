﻿using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.Standard;

namespace DarkSoulsII.DebugView.Model.GameObjects.GameEntities
{
    public class DemoCharacterCtrl : CharacterCtrlBase, IReadable<DemoCharacterCtrl>
    {
        public new DemoCharacterCtrl Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            Name = pointerFactory.Create<StdWstring>(address + 0x00B0, relative, true).Unbox(pointerFactory, reader).Value;
            return this;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
