namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Morpheme.EventTrackAction
{
    public class ChrEventTrackActionItem : MorphemeEventTrackAction, IReadable<ChrEventTrackActionItem>
    {
        public new ChrEventTrackActionItem Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}