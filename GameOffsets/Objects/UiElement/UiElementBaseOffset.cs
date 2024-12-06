namespace GameOffsets.Objects.UiElement
{
    using System;
    using System.Runtime.InteropServices;
    using Natives;

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct UiElementBaseOffset
    {
        [FieldOffset(0x000)] public IntPtr Vtable;
        [FieldOffset(0x028)] public IntPtr Self;

        [FieldOffset(0x030)] public StdVector ChildrensPtr; // both points to same children UiElements.
        // 4 childrens are cached here
        // public StdVector ChildrensPtr; // both points to same children UiElements.
        // 4 childrens are cached here

        [FieldOffset(0xA8)] public StdTuple2D<float> PositionModifier;
        [FieldOffset(0xB0)] public byte ScaleIndex; // root = 3, child of root = 3 and first child of that child = 2
        // Following Ptr is basically pointing to InGameState+0x458.
        // No idea what InGameState+0x458 is pointing to.
        // [FieldOffset(0x088)] public IntPtr UnknownPtr;

        [FieldOffset(0xC0)] public StdTuple2D<float> RelativePosition; // variable

        [FieldOffset(0xD8)] public float LocalScaleMultiplier;

        [FieldOffset(0x120)] public StdWString StringIdPtr;
        // TODO: 0x08 byte gap....not sure what's there
        [FieldOffset(0x148)] public IntPtr ParentPtr; // UiElement.
        // [FieldOffset(0x108)] public float Scale; // !!do not use this!!, this scale provided by game is wrong.
        [FieldOffset(0x150)] public uint Flags; // variable

        [FieldOffset(0x198)] public StdTuple2D<float> UnscaledSize; // variable

        // public uint BorderColor; // BackgroundColor - 0x04
        [FieldOffset(0x1DC)] public uint BackgroundColor;
    }

    public static class UiElementBaseFuncs
    {
        private const int SHOULD_MODIFY_BINARY_POS = 0x0A;
        private const int IS_VISIBLE_BINARY_POS = 0x0B;

        /// <summary>
        ///     This value is extracted from GGPK -> Metadata -> UI -> UISettings.xml
        /// </summary>
        public static readonly StdTuple2D<double> BaseResolution = new(2560, 1600);

        public static Func<uint, bool> IsVisibleChecker = param =>
        {
            return Util.isBitSetUint(param, IS_VISIBLE_BINARY_POS);
        };

        public static Func<uint, bool> ShouldModifyPos = param =>
        {
            return Util.isBitSetUint(param, SHOULD_MODIFY_BINARY_POS);
        };
    }
}