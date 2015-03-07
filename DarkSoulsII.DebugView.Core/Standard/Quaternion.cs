namespace DarkSoulsII.DebugView.Core.Standard
{
    public class Quaternion : IReadable<Quaternion>
    {
        public Quaternion Read(IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
