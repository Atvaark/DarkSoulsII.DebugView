﻿namespace DarkSoulsII.DebugView.Core
{
    public interface IRttiResolver<out T> where T : class, IReadable<T>, new()
    {
        IPointer<T> ResolvePointer(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false);
    }
}
