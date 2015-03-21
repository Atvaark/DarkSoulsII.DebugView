namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Morpheme.EventTrackAction
{
    public class ChrEventTrackActionStateControl : MorphemeEventTrackAction, IReadable<ChrEventTrackActionStateControl>
    {
        public new ChrEventTrackActionStateControl Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}