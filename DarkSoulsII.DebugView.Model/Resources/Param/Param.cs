﻿using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Resources.Param
{
    public class Param : IReadable<Param>
    {
        public string Name { get; set; }

        public Param Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            // TODO: Implement generic param structure reading
            return this;
        }
    }
}
