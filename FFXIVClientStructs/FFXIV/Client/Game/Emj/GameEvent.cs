namespace FFXIVClientStructs.FFXIV.Client.Game.Emj;

/// <remarks>
/// Used for events received from the server, events from the local engine and actions decided by the AI
/// </remarks>
[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x14)]
public partial struct GameEvent {
    [FieldOffset(0x00)] public uint Seat;
    [FieldOffset(0x04)] public uint Action;
    /// <remarks>
    /// Tile id, tile id &gt;&gt; 2 = tile kind, 0xFFFF if unused
    /// </remarks>
    [FieldOffset(0x08), FixedSizeArray] internal FixedSizeArray4<ushort> _tileIds;
}
