﻿namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.App
{
    public class AppResourceManager : IReadable<AppResourceManager>
    {
        public AppResourceManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
