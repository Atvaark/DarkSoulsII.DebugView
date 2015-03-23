namespace DarkSoulsII.DebugView.Core.DarkSoulsII.StateAct
{
    public class StateActGraph : IReadable<StateActGraph>
    {
        public StateActGraph Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            // 0010 Vector
            return this;
        }
    }
}