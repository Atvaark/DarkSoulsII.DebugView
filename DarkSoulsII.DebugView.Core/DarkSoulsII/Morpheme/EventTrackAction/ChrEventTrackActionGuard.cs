namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Morpheme.EventTrackAction
{
    public class ChrEventTrackActionGuard : MorphemeEventTrackAction, IReadable<ChrEventTrackActionGuard>
    {
        public new ChrEventTrackActionGuard Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}