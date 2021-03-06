﻿using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.GameData
{
    public class UserData000 : IReadable<UserData000>
    {
        public string SteamId { get; set; }

        public UserData000 Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            SteamId = reader.ReadAnsiString(16, address + 0x0015, relative);
            return this;
        }
    }
}
