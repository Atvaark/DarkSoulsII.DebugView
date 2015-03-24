using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Morpheme.EventTrackAction
{
    public class ChrEventTrackActionIk : MorphemeEventTrackAction, IReadable<ChrEventTrackActionIk>
    {
        public new ChrEventTrackActionIk Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}