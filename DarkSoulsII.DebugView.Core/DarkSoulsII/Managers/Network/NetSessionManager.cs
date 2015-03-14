﻿using DarkSoulsII.DebugView.Core.DarkSoulsII.Network;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Network
{
    public class NetSessionManager : IReadable<NetSessionManager>
    {
        public ServerInfo ServerInfo { get; set; }
        public NetLatencyManager LatencyManager { get; set; }

        public NetSessionManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            ServerInfo = pointerFactory.Create<ServerInfo>(address + 0x002C, relative, true).Unbox(pointerFactory, reader);
            LatencyManager = pointerFactory.Create<NetLatencyManager>(address + 0x005C, relative).Unbox(pointerFactory, reader);
            return this;
        }
    }
}
