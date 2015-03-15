using System.Collections.Generic;
using System.Linq;
using DarkSoulsII.DebugView.Core.DarkSoulsII.Rtti;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Camera.Operators
{
    public class TransitionCameraOperator : PerspectiveCameraOperator, IReadable<TransitionCameraOperator>
    {
        public TransitionCameraOperator()
        {
            CameraOperators = new List<CameraOperator>();
        }

        public List<CameraOperator> CameraOperators { get; set; }
        public CameraOperator CurrentOperator { get; set; }
        public CameraOperatorType CurrentOperatorType { get; set; }

        public new TransitionCameraOperator Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            // TODO: Check if there is an initialized flag in this class
            var cameraOperatorsPointer = GenericPointer.Create(reader, address + 0x00B4, relative);
            if (cameraOperatorsPointer.IsNull)
                return this;

            var cameraOperators = cameraOperatorsPointer
                .Unbox(reader, (r, a) => r.ReadInt32(10, a))
                .Select(a => new CameraOperatorHelper().ResolvePointer(pointerFactory, reader, a).Unbox(pointerFactory, reader));
            CameraOperators.AddRange(cameraOperators);
            var index = reader.ReadInt32(address + 0x00C4, relative);
            CurrentOperator = CameraOperators.ElementAt(index);
            CurrentOperatorType = (CameraOperatorType)index;
            int freeze = reader.ReadInt32(address + 0x00C8, relative);
            int index2 = reader.ReadInt32(address + 0x00CC, relative);
            return this;
        }
    }
}
