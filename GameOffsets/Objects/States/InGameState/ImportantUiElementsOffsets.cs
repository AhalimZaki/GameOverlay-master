namespace GameOffsets.Objects.States.InGameState
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    ///     All offsets over here are UiElements.
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct ImportantUiElementsOffsets
    {
        [FieldOffset(0x498)] public IntPtr ChatParentPtr;
        [FieldOffset(0x5B0)] public IntPtr PassiveSkillTreePanel;
        [FieldOffset(0x640)] public IntPtr MapParentPtr; // add 0x168 for controller
        [FieldOffset(0x7A8)] public IntPtr ControllerModeMapParentPtr;
    }

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct MapParentStruct
    {
        [FieldOffset(0x48)] public IntPtr LargeMapPtr; // 1st child ~ reading from cache location
        [FieldOffset(0x50)] public IntPtr MiniMapPtr; // 2nd child ~ reading from cache location
    }

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct PassiveSkillTreeStruct
    {
        [FieldOffset(0x50)] public IntPtr SkillTreeNodeUiElements; // 2nd child ~ reading from cache location
    }
}
