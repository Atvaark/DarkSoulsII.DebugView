using DarkSoulsII.DebugView.Core.DarkSoulsII.GameObjects.GameEntities;
using DarkSoulsII.DebugView.Core.Exceptions;
using DarkSoulsII.DebugView.Core.Rtti;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Rtti
{
    public class CharacterCtrlBaseResolver : IRttiResolver<CharacterCtrlBase>
    {
        private static CharacterCtrlBaseResolver _instance;

        private CharacterCtrlBaseResolver()
        {
        }

        public static CharacterCtrlBaseResolver Instance
        {
            get { return _instance ?? (_instance = new CharacterCtrlBaseResolver()); }
        }

        public IPointer<CharacterCtrlBase> ResolvePointer(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            if (address == 0)
                return null;

            int vtable;
            try
            {
                vtable = reader.ReadInt32(address, relative);
            }
            catch (MemoryInaccessibleException)
            {
                return null;
            }

            IPointer<CharacterCtrlBase> pointer;
            switch (vtable)
            {
                case 0x012D2054:
                    pointer = pointerFactory.Create<PlayerCtrl>(address, relative, true);
                    break;
                case 0x012CE454:
                    pointer = pointerFactory.Create<CharacterCtrl>(address, relative, true);
                    break;
                case 0x012CEB44:
                    pointer = pointerFactory.Create<DemoCharacterCtrl>(address, relative, true);
                    break;
                case 0x012CE5EC:
                    pointer = pointerFactory.Create<CharacterCtrlBase>(address, relative, true);
                    break;
                default:
                    pointer = null;
                    break;
            }
            return pointer;
        }
    }
}
