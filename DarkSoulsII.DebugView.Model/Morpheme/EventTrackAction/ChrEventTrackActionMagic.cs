using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Morpheme.EventTrackAction
{
    public class ChrEventTrackActionMagic : MorphemeEventTrackAction, IReadable<ChrEventTrackActionMagic>
    {
        public new ChrEventTrackActionMagic Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}