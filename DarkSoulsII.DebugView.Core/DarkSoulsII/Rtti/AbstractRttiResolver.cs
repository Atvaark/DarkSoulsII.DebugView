using DarkSoulsII.DebugView.Core.Exceptions;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Rtti
{
    public abstract class AbstractRttiResolver<T> : IRttiResolver<T> where T : class, IReadable<T>, new()
    {
        // TODO: Implement resolving non dereferenced pointers
        public IPointer<T> ResolvePointer(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            if (address == 0)
                return null;

            int vtable;
            try
            {
                vtable = reader.ReadInt32(address, relative);
            }
            catch (MemoryInaccessibleException)
            {
                return null;
            }

            return ResolvePointerTransitive(pointerFactory, address, relative, vtable);
        }

        protected abstract IPointer<T> ResolvePointerTransitive(IPointerFactory pointerFactory, int address, bool relative, int vtable);
    }
}