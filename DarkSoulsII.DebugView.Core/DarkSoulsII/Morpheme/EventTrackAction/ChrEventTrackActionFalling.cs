namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Morpheme.EventTrackAction
{
    public class ChrEventTrackActionFalling : MorphemeEventTrackAction, IReadable<ChrEventTrackActionFalling>
    {
        public new ChrEventTrackActionFalling Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}