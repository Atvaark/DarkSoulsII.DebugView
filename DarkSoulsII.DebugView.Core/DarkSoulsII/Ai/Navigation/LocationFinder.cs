namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Ai.Navigation
{
    public class LocationFinder : IReadable<LocationFinder>
    {
        public NaviGraphWorld NaviGraphWorld { get; set; }

        public LocationFinder Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            NaviGraphWorld = pointerFactory.Create<NaviGraphWorld>(address + 0x0010, relative).Unbox(pointerFactory, reader);
            return this;
        }

    }
}