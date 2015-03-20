namespace DarkSoulsII.DebugView.Core
{
    public interface IPointerFactory
    {
        IPointer<T> Create<T>(int address, bool relative = false, bool dereferenced = false, bool searchCache = false) where T : class, IReadable<T>, new();
        IPointerProxy<T> CreateProxy<T>(int address, bool relative = false, bool dereferenced = false, bool searchCache = false) where T : class, IReadable<T>, new();
        IPointer<T>[] CreateArray<T>(int address, bool relative = false, int count = 1) where T : class, IReadable<T>, new();
        IPointer<T>[] CreateArrayDereferenced<T>(int address, bool relative = false, int count = 1) where T : class, IFixedSize, IReadable<T>, new();
        void RemoveProxy<T>(int address, bool relative = false, bool dereferenced = false) where T : class, IReadable<T>, new();
    }
}