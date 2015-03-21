namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Morpheme.EventTrackAction
{
    public class ChrEventTrackActionEventAction : MorphemeEventTrackAction, IReadable<ChrEventTrackActionEventAction>
    {
        public new ChrEventTrackActionEventAction Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}