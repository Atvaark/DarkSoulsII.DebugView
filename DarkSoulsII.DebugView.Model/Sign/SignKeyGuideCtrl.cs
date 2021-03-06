﻿using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.Standard;

namespace DarkSoulsII.DebugView.Model.Sign
{
    public class SignKeyGuideCtrl : IReadable<SignKeyGuideCtrl>
    {
        public Vector3 Position { get; set; }

        public SignKeyGuideCtrl Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            Position = pointerFactory.Create<Vector3>(address + 0x0020, relative, true).Unbox(pointerFactory, reader);
            return this;
        }
    }
}
