﻿using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Managers.Network
{
    public class NetSvrBreakInManager : IReadable<NetSvrBreakInManager>
    {
        public NetSvrBreakInManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
