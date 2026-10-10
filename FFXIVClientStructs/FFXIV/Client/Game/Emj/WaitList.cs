namespace FFXIVClientStructs.FFXIV.Client.Game.Emj;

// Client::Game::Emj::WaitList
[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x84)]
public unsafe partial struct WaitList {
    [FieldOffset(0x00)] public int Count;
    /// <remarks>
    /// Tile kinds that complete the hand, sorted ascending
    /// </remarks>
    [FieldOffset(0x04), FixedSizeArray] internal FixedSizeArray15<uint> _tiles;
    /// <remarks>
    /// Number of copies of each wait tile that are not visible to the player
    /// </remarks>
    [FieldOffset(0x40), FixedSizeArray] internal FixedSizeArray15<int> _remaining;
    [FieldOffset(0x7C)] public int TotalRemaining;
    /// <remarks>
    /// Set when the waits were found by the Thirteen Orphans check
    /// </remarks>
    [FieldOffset(0x80)] public bool IsKokushiWait;
}
