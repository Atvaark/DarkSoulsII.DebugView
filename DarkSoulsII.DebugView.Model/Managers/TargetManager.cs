using System.Collections.Generic;
using System.Linq;
using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.GameObjects.Target;
using DarkSoulsII.DebugView.Model.Target;

namespace DarkSoulsII.DebugView.Model.Managers
{
    public class TargetManager : IReadable<TargetManager>
    {
        public List<TargetCtrl> Targets { get; set; }

        public TargetManager()
        {
            Targets = new List<TargetCtrl>();
        }

        public TargetManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            int targetCount = reader.ReadInt32(address + 0x4008, relative);
            Targets = pointerFactory.CreateArrayDereferenced<TargetIndex>(address + 0x0008, relative, targetCount)
                .Select(p => p.Unbox(pointerFactory, reader).TargetCtrl)
                .ToList();
            return this;
        }

    }
}