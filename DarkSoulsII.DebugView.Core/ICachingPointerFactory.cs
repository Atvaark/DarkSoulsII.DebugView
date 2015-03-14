namespace DarkSoulsII.DebugView.Core
{
    public interface ICachingPointerFactory : IPointerFactory
    {
        IPointer<T> CreateProxy<T>(int address, bool relative = false, bool dereferenced = false) where T : class, IReadable<T>, new();
        void RemoveProxy<T>(int address, bool relative = false, bool dereferenced = false) where T : class, IReadable<T>, new();
    }
}