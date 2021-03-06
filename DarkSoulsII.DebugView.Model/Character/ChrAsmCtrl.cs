﻿using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.Character.Gestures;

namespace DarkSoulsII.DebugView.Model.Character
{
    public class ChrAsmCtrl : IReadable<ChrAsmCtrl>
    {
        public ChrBodyScale BodyScale { get; set; }
        public ChrAsmCtrlGestures Gestures { get; set; }
        public ChrAsmCtrlEquipment Equipment { get; set; }

        public ChrAsmCtrl Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            BodyScale = pointerFactory.Create<ChrBodyScale>(address + 0x000C, relative).Unbox(pointerFactory, reader);
            Gestures = pointerFactory.Create<ChrAsmCtrlGestures>(address + 0x0010, relative).Unbox(pointerFactory, reader);
            Equipment = pointerFactory.Create<ChrAsmCtrlEquipment>(address + 0x0014, relative).Unbox(pointerFactory, reader);
            return this;
        }

    }
}
