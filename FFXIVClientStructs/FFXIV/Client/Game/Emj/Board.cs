namespace FFXIVClientStructs.FFXIV.Client.Game.Emj;

// Client::Game::Emj::Board
// ctor inlined in Table ctor
[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0xCF8)]
public unsafe partial struct Board {
    /// <remarks>
    /// Indexed by seat
    /// </remarks>
    [FieldOffset(0x000), FixedSizeArray] internal FixedSizeArray4<MeldList> _meldLists;
    /// <remarks>
    /// Indexed by seat
    /// </remarks>
    [FieldOffset(0x560), FixedSizeArray] internal FixedSizeArray4<DiscardPile> _discardPiles;
    [FieldOffset(0x990)] public RoundState RoundState;

    [GenerateInterop]
    [StructLayout(LayoutKind.Explicit, Size = 0xFC)]
    public partial struct DiscardPile {
        [FieldOffset(0x00)] public int Count;
        /// <remarks>
        /// Tile kind, entries with a value of 127 are skipped when reading the pile
        /// </remarks>
        [FieldOffset(0x04), FixedSizeArray] internal FixedSizeArray31<uint> _tiles;
        [FieldOffset(0x80), FixedSizeArray] internal FixedSizeArray31<uint> _flags;
    }
}
