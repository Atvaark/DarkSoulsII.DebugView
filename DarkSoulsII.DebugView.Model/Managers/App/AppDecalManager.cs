﻿using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Managers.App
{
    public class AppDecalManager : IReadable<AppDecalManager>
    {
        public AppDecalManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            // TODO: Add AppDecalManagerParamContainer 0180
            return this;
        }
    }
}
