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
    [FieldOffset(0x154)] public int RiichiDiscardCount;
    /// <remarks>
    /// Tiles that can be discarded when declaring riichi, tile kind | 0x100 for red fives
    /// </remarks>
    [FieldOffset(0x158), FixedSizeArray] internal FixedSizeArray14<uint> _riichiDiscards;
    [FieldOffset(0x190)] public bool CanRiichi;
    [FieldOffset(0x194)] public bool InTenpai;
    /// <remarks>
    /// Copy of HandAnalyzer.Waits, set by IsTenpai
    /// </remarks>
    [FieldOffset(0x198)] public WaitList Waits;

    [FieldOffset(0x378)] public HandAnalyzer* HandAnalyzer;
    [FieldOffset(0x380)] public WinResult* WinResult;

    [MemberFunction("33 C0 89 81 ?? ?? ?? ?? 48 89 81 ?? ?? ?? ?? 48 89 81 ?? ?? ?? ?? 48 89 81 ?? ?? ?? ?? 48 89 81 ?? ?? ?? ?? 48 8B C1")]
    public partial Player* Ctor();

    [MemberFunction("E8 ?? ?? ?? ?? 49 8B 47 ?? 4D 8D 7F")]
    public partial void Initialize(void* a2, void* rules, RoundState* roundState, int a5);

    [MemberFunction("E8 ?? ?? ?? ?? 8B C8 03 D8")]
    public partial int CountRedFives();

    [MemberFunction("E8 ?? ?? ?? ?? 85 C0 75 ?? FF C6 83 FE")]
    public partial bool AnalyzeWin();

    [MemberFunction("E8 ?? ?? ?? ?? FF C7 48 8D 76 ?? 48 83 C5")]
    public partial bool IsTenpai();

    [MemberFunction("E8 ?? ?? ?? ?? 48 8B 93 ?? ?? ?? ?? 44 8B 8A")]
    public partial bool FindRiichiDiscards(uint tile);

    [MemberFunction("E8 ?? ?? ?? ?? 8B 56 ?? 81 EA")]
    public partial uint GetAvailableActions(void* a2);
}
