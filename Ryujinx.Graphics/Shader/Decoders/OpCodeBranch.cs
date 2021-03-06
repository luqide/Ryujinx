using Ryujinx.Graphics.Shader.Instructions;

namespace Ryujinx.Graphics.Shader.Decoders
{
    class OpCodeBranch : OpCode
    {
        public int Offset { get; }

        public OpCodeBranch(InstEmitter emitter, ulong address, long opCode) : base(emitter, address, opCode)
        {
            Offset = ((int)(opCode >> 20) << 8) >> 8;
        }

        public ulong GetAbsoluteAddress()
        {
            return (ulong)((long)Address + (long)Offset + 8);
        }
    }
}