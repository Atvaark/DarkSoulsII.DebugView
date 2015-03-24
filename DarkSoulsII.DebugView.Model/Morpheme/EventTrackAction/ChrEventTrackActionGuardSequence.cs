using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Morpheme.EventTrackAction
{
    public class ChrEventTrackActionGuardSequence : MorphemeEventTrackAction, IReadable<ChrEventTrackActionGuardSequence>
    {
        public new ChrEventTrackActionGuardSequence Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}