﻿namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Controllers
{
    public class SignPreviewCtrl : IReadable<SignPreviewCtrl>
    {
        public SignPreviewCtrl Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
