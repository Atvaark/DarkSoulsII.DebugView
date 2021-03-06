﻿using System.Collections.Generic;
using System.Linq;
using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.GameObjects.GameEntities;
using DarkSoulsII.DebugView.Model.Resources.Param.Containers;
using DarkSoulsII.DebugView.Model.Rtti;

namespace DarkSoulsII.DebugView.Model.Managers.Character
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

        public CharacterManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            // TODO: Check if +0000 contains game objects

            var characterControlResolver = new CharacterCtrlBaseResolver();
            var characterControlPointers = reader.ReadInt32(80, address + 0x0028)
                .Select(rawPointer => characterControlResolver.ResolvePointer(pointerFactory, reader, rawPointer))
                .Where(pointer => pointer != null);

            foreach (var characterControlPointer in characterControlPointers)
            {
                var characterControl = characterControlPointer.Unbox(pointerFactory, reader);
                if(characterControl != null)
                    CharacterControls.Add(characterControl);
            }

            var playerControlPointers =
                reader.ReadInt32(4, address + 0x0168)
                    .Select(a => pointerFactory.Create<PlayerCtrl>(a))
                    .Where(pointer => pointer.IsNull == false);
            foreach (var pointer in playerControlPointers)
            {
                PlayerControls.Add(pointer.Unbox(pointerFactory, reader));
            }


            byte characterControlCount = reader.ReadByte(address + 0x0178);
            byte playerControlCount = reader.ReadByte(address + 0x0179);

            // TODO: Enable when it is cached correctly
            // ParamContainer = pointerFactory.Create<CharacterParamContainer>(address + 0x0188, relative, true).Unbox(pointerFactory, reader);
            return this;
        }
    }
}
