namespace DarkSoulsII.DebugView.Core
{
    public interface IPointerProxy<out T> : IPointer<T> where T : class, IReadable<T>, new()
    {
        T Value { get; }
        bool ValueInitialized { get; }
    }
}