namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Morpheme.EventTrackAction
{
    public class ChrEventTrackActionRope : MorphemeEventTrackAction, IReadable<ChrEventTrackActionRope>
    {
        public new ChrEventTrackActionRope Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}