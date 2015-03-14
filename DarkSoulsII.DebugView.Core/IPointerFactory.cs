namespace DarkSoulsII.DebugView.Core
{
    public interface IPointerFactory
    {
        IPointer<T> Create<T>(int address, bool relative = false, bool dereferenced = false) where T : class, IReadable<T>, new();
    }
}