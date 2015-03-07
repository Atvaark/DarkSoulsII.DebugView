namespace DarkSoulsII.DebugView.Core
{
    public interface IPointer<out T> where T : class, IReadable<T>, new()
    {
        bool IsNull { get; }
        T Unbox(IReader reader);
        T TryUnbox(IReader reader);
    }
}
