namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Morpheme.EventTrackAction
{
    public class ChrEventTrackActionFootEffect : MorphemeEventTrackAction, IReadable<ChrEventTrackActionFootEffect>
    {
        public new ChrEventTrackActionFootEffect Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}