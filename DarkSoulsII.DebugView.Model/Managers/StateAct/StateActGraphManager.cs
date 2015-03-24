using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Managers.StateAct
{
    public class StateActGraphManager : IReadable<StateActGraphManager>
    {
        public StateActGraphManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}