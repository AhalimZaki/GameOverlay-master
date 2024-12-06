namespace GameOffsets.Objects.Components
{
    using System;
    using System.Runtime.InteropServices;
    using GameOffsets.Natives;

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct TargetableOffsets
    {
        [FieldOffset(0x00)] public ComponentHeader Header;
        [FieldOffset(0x48)] public uint TargetableFlag;
        [FieldOffset(0x50)] public uint HiddenFlag;
    }

    public static class TargetableHelper
    {
        public static Func<uint, bool> IsTargetable = param => { return Util.isBitSetUint(param, 0); };
    }
}
