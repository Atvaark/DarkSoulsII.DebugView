﻿namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Network
{
    public class NetSvrVisitorManager : IReadable<NetSvrVisitorManager>
    {
        public NetSvrVisitorManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
