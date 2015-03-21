namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Morpheme.EventTrackAction
{
    public class ChrEventTrackActionDoor : MorphemeEventTrackAction, IReadable<ChrEventTrackActionDoor>
    {
        public new ChrEventTrackActionDoor Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}