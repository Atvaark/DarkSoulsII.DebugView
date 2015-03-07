namespace DarkSoulsII.DebugView.Core
{
    public interface IReadable<out T>
    {
        T Read(IReader reader, int address, bool relative = false);
    }
}
