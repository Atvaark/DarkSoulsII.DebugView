namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers
{
    public class StateActManager : IReadable<StateActManager>
    {
        public StateActManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}