namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.StateAct
{
    public class StateActGraphManager : IReadable<StateActGraphManager>
    {
        public StateActGraphManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}