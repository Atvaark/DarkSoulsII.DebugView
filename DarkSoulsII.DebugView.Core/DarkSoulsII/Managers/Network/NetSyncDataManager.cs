﻿namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Network
{
    public class NetSyncDataManager : IReadable<NetSyncDataManager>
    {
        public NetSyncDataManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
