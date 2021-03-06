﻿using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Camera.Operators
{
    public class FreeOrthoCameraOperator : OrthoCameraOperator, IReadable<FreeOrthoCameraOperator>
    {
        public new FreeOrthoCameraOperator Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}
