﻿using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Managers.Network
{
    public class NetSummonSlotAreaManager : IReadable<NetSummonSlotAreaManager>
    {
        public NetSummonSlotAreaManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            // 0004
            // 0008
            // 000C
            return this;
        }
    }
}
