using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Morpheme.EventTrackAction
{
    public class MorphemeEventTrackAction : IReadable<MorphemeEventTrackAction>
    {
        public MorphemeEventTrackAction Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}