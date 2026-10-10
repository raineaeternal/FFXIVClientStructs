namespace FFXIVClientStructs.FFXIV.Client.Game.Emj;

// Client::Game::Emj::Player
// ctor "33 C0 89 81 ?? ?? ?? ?? 48 89 81 ?? ?? ?? ?? 48 89 81 ?? ?? ?? ?? 48 89 81 ?? ?? ?? ?? 48 89 81 ?? ?? ?? ?? 48 8B C1"
[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x388)]
public unsafe partial struct Player {
    [FieldOffset(0x004)] public uint Seat;
    [FieldOffset(0x008)] public int HandTileCount;
    /// <remarks>
    /// Number of tiles in hand per tile kind
    /// </remarks>
    [FieldOffset(0x00C), FixedSizeArray] internal FixedSizeArray34<uint> _tileCounts;
    /// <remarks>
    /// Number of red fives in hand per tile kind
    /// </remarks>
    [FieldOffset(0x094), FixedSizeArray] internal FixedSizeArray34<uint> _redTileCounts;
    [FieldOffset(0x11C), FixedSizeArray] internal FixedSizeArray14<uint> _handTiles;

    /// <remarks>
    /// Client::Game::Emj::HandAnalyzer
    /// </remarks>
    [FieldOffset(0x378)] public void* HandAnalyzer;
    /// <remarks>
    /// Client::Game::Emj::WinResult
    /// </remarks>
    [FieldOffset(0x380)] public void* WinResult;
}
