using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Ai.Navigation
{
    public class RouteNavigator : IReadable<RouteNavigator>
    {
        public RouteNavigator Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}