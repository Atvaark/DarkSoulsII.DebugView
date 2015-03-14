using System.Collections.Generic;
using System.Linq;
using DarkSoulsII.DebugView.Core.DarkSoulsII.GameObjects.GameEntities;
using DarkSoulsII.DebugView.Core.DarkSoulsII.Resources.Param.Containers;
using DarkSoulsII.DebugView.Core.DarkSoulsII.Rtti;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Character
{
    public class CharacterManager : IReadable<CharacterManager>
    {
        public CharacterManager()
        {
            CharacterControls = new List<CharacterCtrlBase>();
            PlayerControls = new List<PlayerCtrl>();
        }

        public List<CharacterCtrlBase> CharacterControls { get; set; }
        public List<PlayerCtrl> PlayerControls { get; set; }
        public CharacterParamContainer ParamContainer { get; set; }

        public CharacterManager Read(IReader reader, int address, bool relative = false)
        {
            var characterControlPointerstest = reader.ReadInt32(80, address + 0x0028)
                .Select(rawPointer => CharacterCtrlBaseResolver.Instance.ResolvePointer(reader, rawPointer))
                .Where(pointer => pointer != null && pointer.IsNull == false);

            foreach (var pointer in characterControlPointerstest)
            {
                CharacterControls.Add(pointer.Unbox(reader));
            }

            var playerControlPointers =
                reader.ReadInt32(4, address + 0x0168)
                    .Select(a => Pointer<PlayerCtrl>.Create(a))
                    .Where(pointer => pointer.IsNull == false);
            foreach (var pointer in playerControlPointers)
            {
                PlayerControls.Add(pointer.Unbox(reader));
            }


            byte characterControlCount = reader.ReadByte(address + 0x0178);
            byte playerControlCount = reader.ReadByte(address + 0x0179);

            // Disabled until caching is implemented
            ////ParamContainer = Pointer<CharacterParamContainer>.Create(address + 0x0188).Unbox(reader);


            return this;
        }
    }
}
