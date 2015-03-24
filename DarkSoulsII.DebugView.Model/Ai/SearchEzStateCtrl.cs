using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Ai
{
    public class SearchEzStateCtrl : IReadable<SearchEzStateCtrl>
    {
        public SearchEzStateCtrl Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}