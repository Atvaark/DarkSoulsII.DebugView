﻿using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Ai.Navigation
{
    public class NaviGraphParts : IReadable<NaviGraphParts>
    {
        public NaviGraphParts Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}