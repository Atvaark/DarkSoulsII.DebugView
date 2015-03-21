namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Model
{
    public class CharacterModelCtrl : IReadable<CharacterModelCtrl>
    {
        public AppFlverModelCtrl FlverModelCtrl { get; set; }

        public CharacterModelCtrl Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            FlverModelCtrl = pointerFactory.Create<AppFlverModelCtrl>(address + 0x0010, relative, true).Unbox(pointerFactory, reader);
            return this;
        }

    }
}