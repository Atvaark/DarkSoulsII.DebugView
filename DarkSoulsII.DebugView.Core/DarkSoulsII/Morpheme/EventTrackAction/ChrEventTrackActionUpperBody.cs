namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Morpheme.EventTrackAction
{
    public class ChrEventTrackActionUpperBody : MorphemeEventTrackAction, IReadable<ChrEventTrackActionUpperBody>
    {
        public new ChrEventTrackActionUpperBody Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}