namespace DarkSoulsII.DebugView.Core
{
    public interface IPointer<out T> where T : class, IReadable<T>, new()
    {
        bool IsNull { get; }
        bool Dereferenced { get; }
        T Unbox(IPointerFactory pointerFactory, IReader reader);
        T TryUnbox(IPointerFactory pointerFactory, IReader reader);
        void Dereference(IReader reader);
    }
}
