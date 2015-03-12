﻿namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Resources.Param
{
    public class ParamFileResourceObjectForRegulation<T> : ParamFileResourceObject<T>,
        IReadable<ParamFileResourceObjectForRegulation<T>> where T : class, IReadable<T>, new()
    {
        public new ParamFileResourceObjectForRegulation<T> Read(IReader reader, int address, bool relative = false)
        {
            base.Read(reader, address, relative);
            return this;
        }
    }
}