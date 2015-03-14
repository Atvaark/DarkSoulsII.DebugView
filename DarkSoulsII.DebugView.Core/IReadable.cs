namespace DarkSoulsII.DebugView.Core
{
    public interface IReadable<out T>
    {
        T Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false);
    }
}
