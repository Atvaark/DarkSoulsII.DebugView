namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Ai
{
    public class ChrAiBase : IReadable<ChrAiBase>
    {
        public ChrAiBase Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}