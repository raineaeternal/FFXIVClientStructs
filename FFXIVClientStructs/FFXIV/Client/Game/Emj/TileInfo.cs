namespace FFXIVClientStructs.FFXIV.Client.Game.Emj;

// Client::Game::Emj::TileInfo
// ctor inlined in Table ctor
[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x1C)]
public unsafe partial struct TileInfo {
    [FieldOffset(0x00)] public uint Seat;
    /// <remarks>
    /// Tile kind
    /// </remarks>
    [FieldOffset(0x08)] public uint Tile;
    [FieldOffset(0x0C)] public uint Flags;
    /// <remarks>
    /// Copied from the tile attribute table for Tile
    /// </remarks>
    [FieldOffset(0x10)] public uint Attributes;
}
