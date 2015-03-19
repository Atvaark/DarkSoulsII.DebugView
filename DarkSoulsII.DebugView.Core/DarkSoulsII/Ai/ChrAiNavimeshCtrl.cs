using DarkSoulsII.DebugView.Core.DarkSoulsII.Ai.Navigation;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Ai
{
    public class ChrAiNavimeshCtrl : IReadable<ChrAiNavimeshCtrl>
    {
        public RoutePlanner RoutePlanner { get; set; }
        public RouteNavigator RouteNavigator { get; set; }

        public ChrAiNavimeshCtrl Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            RoutePlanner = pointerFactory.Create<RoutePlanner>(address + 0x0014, relative).Unbox(pointerFactory, reader);
            RouteNavigator = pointerFactory.Create<RouteNavigator>(address + 0x0018, relative).Unbox(pointerFactory, reader);
            return this;
        }

    }
}