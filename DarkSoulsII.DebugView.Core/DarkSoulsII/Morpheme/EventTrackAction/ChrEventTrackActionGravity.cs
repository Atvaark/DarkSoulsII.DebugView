namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Morpheme.EventTrackAction
{
    public class ChrEventTrackActionGravity : MorphemeEventTrackAction, IReadable<ChrEventTrackActionGravity>
    {
        public new ChrEventTrackActionGravity Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}