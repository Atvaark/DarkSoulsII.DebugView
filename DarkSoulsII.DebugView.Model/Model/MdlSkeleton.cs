using System.Collections.Generic;
using System.Linq;
using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Model
{
    public class MdlSkeleton : IReadable<MdlSkeleton>
    {
        public List<MdlBone> Bones { get; set; }

        public MdlSkeleton Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            // TODO: Find where the bone count is stored.
            const int boneCount = 1;
            int boneAddress = reader.ReadInt32(address + 0x0014, relative);
            Bones = pointerFactory.CreateArrayDereferenced<MdlBone>(boneAddress, false, boneCount)
                .Select(p => p.Unbox(pointerFactory, reader))
                .ToList();
            return this;
        }

    }
}