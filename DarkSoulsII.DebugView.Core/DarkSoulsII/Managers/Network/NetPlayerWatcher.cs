﻿namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Network
{
    public class NetPlayerWatcher : IReadable<NetPlayerWatcher>
    {
        public NetPlayerWatcher Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
