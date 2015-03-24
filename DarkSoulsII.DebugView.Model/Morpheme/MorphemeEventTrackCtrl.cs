using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.Morpheme.EventTrackAction;
using DarkSoulsII.DebugView.Model.Rtti;

namespace DarkSoulsII.DebugView.Model.Morpheme
{
    public class MorphemeEventTrackCtrl : IReadable<MorphemeEventTrackCtrl>
    {
        public MorphemeEventTrackAction CurrentAction { get; set; }

        public MorphemeEventTrackCtrl Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            CurrentAction = pointerFactory.Create<MorphemeEventTrackAction>(address + 0x0010, relative).Unbox(pointerFactory, reader);

            int actionAddress = reader.ReadInt32(address + 0x0010, relative);
            var actionPointer = new MorphemeEventTrackActionResolver().ResolvePointer(pointerFactory, reader, actionAddress);
            if (actionPointer != null)
                CurrentAction = actionPointer.Unbox(pointerFactory, reader);

            return this;
        }

    }
}