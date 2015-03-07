﻿namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Drawing
{
    public class MapTexture : MdlTexture, IReadable<MapTexture>
    {
        public new MapTexture Read(IReader reader, int address, bool relative = false)
        {
            base.Read(reader, address, relative);
            return this;
        }
    }
}
