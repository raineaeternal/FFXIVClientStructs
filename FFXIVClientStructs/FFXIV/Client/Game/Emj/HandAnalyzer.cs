namespace FFXIVClientStructs.FFXIV.Client.Game.Emj;

// Client::Game::Emj::HandAnalyzer
// ctor inlined in Player.Initialize
[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x240)]
public unsafe partial struct HandAnalyzer {
    /// <remarks>
    /// Working decomposition, the open melds occupy the first MeldCount slots
    /// </remarks>
    [FieldOffset(0x000), FixedSizeArray] internal FixedSizeArray5<Group> _groups;
    /// <remarks>
    /// Number of open melds of the player
    /// </remarks>
    [FieldOffset(0x040)] public int MeldCount;
    /// <remarks>
    /// 1 = tenpai check (Player.IsTenpai), 2 = waits after discarding DiscardTile, 3 = waits for every possible discard
    /// </remarks>
    [FieldOffset(0x044)] public int Mode;
    [FieldOffset(0x048)] public int DiscardCandidateCount;
    /// <remarks>
    /// Tile kinds that can be discarded while staying tenpai, sorted ascending
    /// </remarks>
    [FieldOffset(0x04C), FixedSizeArray] internal FixedSizeArray14<uint> _discardCandidates;
    /// <remarks>
    /// Waits after discarding the matching entry of DiscardCandidates
    /// </remarks>
    [FieldOffset(0x090), FixedSizeArray] internal FixedSizeArray14<Pointer<WaitList>> _discardCandidateWaits;
    /// <remarks>
    /// Waits of the current hand
    /// </remarks>
    [FieldOffset(0x110)] public WaitList Waits;
    [FieldOffset(0x194)] public bool IsCheckingKokushi;
    /// <remarks>
    /// Copy of Player.TileCounts
    /// </remarks>
    [FieldOffset(0x198), FixedSizeArray] internal FixedSizeArray34<uint> _tileCounts;
    /// <remarks>
    /// 255 if none
    /// </remarks>
    [FieldOffset(0x220)] public uint DiscardTile;
    [FieldOffset(0x228)] public Player* Player;

    [MemberFunction("48 89 6C 24 ?? 48 89 74 24 ?? 48 89 7C 24 ?? 41 56 45 33 D2 45 8B F0")]
    public partial void AddWait(uint tile, int remaining, uint discardTile);

    [MemberFunction("48 89 5C 24 ?? 48 89 6C 24 ?? 48 89 74 24 ?? 57 41 54 41 55 41 56 41 57 48 83 EC ?? 45 8B E8 48 8B F9")]
    public partial bool RecordWaits(uint* tileCounts, uint tile1, uint tile2);

    [MemberFunction("40 53 55 56 41 54 41 55 41 56 41 57 48 81 EC ?? ?? ?? ?? 48 8B 05 ?? ?? ?? ?? 48 33 C4 48 89 84 24 ?? ?? ?? ?? 33 F6")]
    public partial void FindTankiWaits(uint* tileCounts);

    [MemberFunction("40 55 53 41 54 41 57 48 8D AC 24 ?? ?? ?? ?? 48 81 EC ?? ?? ?? ?? 48 8B 05 ?? ?? ?? ?? 48 33 C4 48 89 85 ?? ?? ?? ?? 44 89 4C 24 ?? 45 8B E1 44 89 44 24 ?? 45 8B C8")]
    public partial void Decompose(uint* tileCounts, int groupCount, uint startTile);

    [MemberFunction("E8 ?? ?? ?? ?? 89 AB ?? ?? ?? ?? 85 C0")]
    public partial bool CheckKokushiWaits(uint* tileCounts);

    [MemberFunction("48 89 5C 24 ?? 56 48 83 EC ?? 48 8B 81 ?? ?? ?? ?? 48 8B D9 83 B8 ?? ?? ?? ?? 00")]
    public partial bool CheckIsolatedShape();

    [MemberFunction("48 89 5C 24 ?? 48 89 6C 24 ?? 56 48 81 EC ?? ?? ?? ?? 48 8B 05 ?? ?? ?? ?? 48 33 C4 48 89 84 24 ?? ?? ?? ?? 33 ED 48 8B D9")]
    public partial bool FindWaits();

    [GenerateInterop]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public partial struct Group {
        /// <remarks>
        /// Only the base type is set
        /// </remarks>
        [FieldOffset(0x00)] public MeldType Type;
        /// <remarks>
        /// Tile kind, the middle tile for sequences
        /// </remarks>
        [FieldOffset(0x04)] public uint Tile;
    }
}
