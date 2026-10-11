namespace FFXIVClientStructs.FFXIV.Client.Game.Emj;

// Client::Game::Emj::Meld
[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x54)]
public unsafe partial struct Meld {
    [FieldOffset(0x04)] public MeldType Type;
    /// <remarks>
    /// Tile kind of the meld, the middle tile for sequences
    /// </remarks>
    [FieldOffset(0x08)] public uint Tile;
    /// <remarks>
    /// Tile kind | 0x100 for red fives, 255 if unused
    /// </remarks>
    [FieldOffset(0x14), FixedSizeArray] internal FixedSizeArray4<uint> _tiles;
    /// <remarks>
    /// Tile kind of the tile that was called
    /// </remarks>
    [FieldOffset(0x24)] public uint CalledTile;
    /// <remarks>
    /// Seat of the player that called the meld
    /// </remarks>
    [FieldOffset(0x2C)] public uint Seat;
    /// <remarks>
    /// Seat of the player that discarded the called tile
    /// </remarks>
    [FieldOffset(0x30)] public uint CalledFromSeat;
    /// <remarks>
    /// (CalledFromSeat - Seat) &amp; 3, 1 = Right, 2 = Across, 3 = Left
    /// </remarks>
    [FieldOffset(0x34)] public uint CalledFromRelativeSeat;
    [FieldOffset(0x4C)] public int Fu;

    [MemberFunction("E8 ?? ?? ?? ?? 3B D8 7D ?? 48 8B 47")]
    public partial int GetTileCount();
}

[Flags]
public enum MeldType : uint {
    None = 0,
    Claimed = 1 << 8,
    WaitKanchan = 1 << 16,
    WaitPenchan = 1 << 17,
    WaitRyanmen = 1 << 18,
    Open = 1 << 22,
    Unknown = 1 << 24,
    Sequence = 1 << 25,
    Pair = 1 << 26,
    Triplet = 1 << 27,
    Quad = 1 << 28,
    AddedQuad = 1 << 29,
    ConcealedQuad = 1 << 30,
}
