using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Morpheme.EventTrackAction
{
    public class ChrEventTrackActionHit : MorphemeEventTrackAction, IReadable<ChrEventTrackActionHit>
    {
        public new ChrEventTrackActionHit Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}