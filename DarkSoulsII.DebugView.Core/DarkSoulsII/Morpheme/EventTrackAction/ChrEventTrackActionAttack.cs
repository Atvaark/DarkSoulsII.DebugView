namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Morpheme.EventTrackAction
{
    public class ChrEventTrackActionAttack : MorphemeEventTrackAction, IReadable<ChrEventTrackActionAttack>
    {
        public new ChrEventTrackActionAttack Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}