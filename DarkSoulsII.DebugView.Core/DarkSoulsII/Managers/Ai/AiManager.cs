namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Ai
{
    public class AiManager : IReadable<AiManager>
    {
        public AiManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
