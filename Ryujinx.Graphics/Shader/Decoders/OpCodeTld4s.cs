using Ryujinx.Graphics.Shader.Instructions;

namespace Ryujinx.Graphics.Shader.Decoders
{
    class OpCodeTld4s : OpCodeTextureScalar
    {
        public bool HasDepthCompare { get; }
        public bool HasOffset       { get; }

        public int GatherCompIndex { get; }

        public OpCodeTld4s(InstEmitter emitter, ulong address, long opCode) : base(emitter, address, opCode)
        {
            HasDepthCompare = opCode.Extract(50);
            HasOffset       = opCode.Extract(51);

            GatherCompIndex = opCode.Extract(52, 2);
        }
    }
}