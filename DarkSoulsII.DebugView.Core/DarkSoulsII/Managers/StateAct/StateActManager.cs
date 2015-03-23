using DarkSoulsII.DebugView.Core.DarkSoulsII.StateAct;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.StateAct
{
    public class StateActManager : IReadable<StateActManager>
    {
        public StateActGraphManager GraphManager { get; set; }
        public NullStateActCtrl NullStateActCtrl { get; set; }
        public StateActElapsedTimeManager StateActElapsedTimeManager { get; set; }

        public StateActManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            GraphManager = pointerFactory.Create<StateActGraphManager>(address + 0x001C, relative).Unbox(pointerFactory, reader);
            // 0020 MapStateActManager 
            NullStateActCtrl = pointerFactory.Create<NullStateActCtrl>(address + 0x0124, relative).Unbox(pointerFactory, reader);
            StateActElapsedTimeManager = pointerFactory.Create<StateActElapsedTimeManager>(address + 0x013C, relative).Unbox(pointerFactory, reader);
            
            return this;
        }

    }
}