﻿namespace GameOffsets.Objects.FilesStructures
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct GrantedEffectsDatOffset
    {
        [FieldOffset(0x63)] public IntPtr ActiveSkillDatPtr;
    }
}
