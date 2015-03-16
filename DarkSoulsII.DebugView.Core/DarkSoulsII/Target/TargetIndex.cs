using DarkSoulsII.DebugView.Core.DarkSoulsII.GameObjects.Target;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Target
{
    public class TargetIndex : IReadable<TargetIndex>, IFixedSize
    {
        public TargetCtrlType TargetType { get; set; }
        public short Index { get; set; }
        public TargetCtrl TargetCtrl { get; set; }
        public int Size
        {
            get { return 8; }
        }

        public TargetIndex Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            TargetType = (TargetCtrlType)reader.ReadInt16(address + 0x0000, relative);
            Index = reader.ReadInt16(address + 0x0002, relative);
            TargetCtrl = CreateTargetCtrlPointer(pointerFactory, address + 0x0004, relative).Unbox(pointerFactory, reader);
            return this;
        }

        private IPointer<TargetCtrl> CreateTargetCtrlPointer(IPointerFactory pointerFactory, int address, bool relative)
        {
            IPointer<TargetCtrl> targetCtrlPointer;
            switch (TargetType)
            {
                case TargetCtrlType.TargetCharacterCtrl:
                    targetCtrlPointer = pointerFactory.Create<TargetCharacterCtrl>(address, relative);
                    break;
                case TargetCtrlType.TargetMapCtrl:
                    targetCtrlPointer = pointerFactory.Create<TargetMapCtrl>(address, relative);
                    break;
                case TargetCtrlType.TargetMapGeneralLocationCtrl:
                    targetCtrlPointer = pointerFactory.Create<TargetMapGeneralLocationCtrl>(address, relative);
                    break;
                case TargetCtrlType.TargetGeneratorCtrl:
                    targetCtrlPointer = pointerFactory.Create<TargetGeneratorCtrl>(address, relative);
                    break;
                case TargetCtrlType.TargetBulletCtrl:
                    targetCtrlPointer = pointerFactory.Create<TargetBulletCtrl>(address, relative);
                    break;
                default:
                    targetCtrlPointer = pointerFactory.Create<TargetCtrl>(address, relative);
                    break;

            }
            return targetCtrlPointer;
        }
    }
}