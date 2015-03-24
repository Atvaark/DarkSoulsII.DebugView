using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Ai.Navigation
{
    public class RoutePlanner : IReadable<RoutePlanner>
    {
        public LocationFinder LocationFinder { get; set; }

        public RoutePlanner Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            LocationFinder = pointerFactory.Create<LocationFinder>(address + 0x0008, relative).Unbox(pointerFactory, reader);
            return this;
        }

    }
}