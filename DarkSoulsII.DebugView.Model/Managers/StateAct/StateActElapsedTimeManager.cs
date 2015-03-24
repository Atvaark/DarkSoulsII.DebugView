using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Managers.StateAct
{
    public class StateActElapsedTimeManager : IReadable<StateActElapsedTimeManager>
    {
        public StateActElapsedTimeManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}