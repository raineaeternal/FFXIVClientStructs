namespace FFXIVClientStructs.FFXIV.Client.Game.Emj;

// Client::Game::Emj::RoundState
// ctor "48 8D 05 ?? ?? ?? ?? 48 89 51 70"
/// <remarks>
/// Arrays marked "by seat" are indexed by GameEvent.Seat, arrays marked "by position" are indexed by (seat + Dealer + StartSeatOffset) &amp; 3
/// </remarks>
[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x368)]
public unsafe partial struct RoundState {
    /// <remarks>
    /// By position, in hundreds
    /// </remarks>
    [FieldOffset(0x028), FixedSizeArray] internal FixedSizeArray4<int> _points;
    [FieldOffset(0x03C)] public int RoundWind;
    /// <remarks>
    /// 0-3, the hand within the current wind round
    /// </remarks>
    [FieldOffset(0x040)] public int Dealer;
    [FieldOffset(0x044)] public int Honba;
    /// <remarks>
    /// Total riichi sticks on the table
    /// </remarks>
    [FieldOffset(0x04C)] public int RiichiSticks;
    /// <remarks>
    /// By position
    /// </remarks>
    [FieldOffset(0x050), FixedSizeArray] internal FixedSizeArray4<int> _riichiSticksByPosition;
    [FieldOffset(0x070)] public void* Rules;
    [FieldOffset(0x078)] public MeldList* MeldLists;
    [FieldOffset(0x080)] public Board.DiscardPile* DiscardPiles;
    [FieldOffset(0x090)] public int Turn;
    /// <remarks>
    /// By seat, cleared on any call
    /// </remarks>
    [FieldOffset(0x094), FixedSizeArray] internal FixedSizeArray4<int> _isFirstTurn;
    /// <remarks>
    /// By seat, 100 if not in riichi
    /// </remarks>
    [FieldOffset(0x0A4), FixedSizeArray] internal FixedSizeArray4<int> _riichiTurn;
    /// <remarks>
    /// By seat
    /// </remarks>
    [FieldOffset(0x0B4), FixedSizeArray] internal FixedSizeArray4<int> _isRiichi;
    /// <remarks>
    /// By seat
    /// </remarks>
    [FieldOffset(0x0C4), FixedSizeArray] internal FixedSizeArray4<int> _isDoubleRiichi;
    /// <remarks>
    /// By seat
    /// </remarks>
    [FieldOffset(0x0D4), FixedSizeArray] internal FixedSizeArray4<int> _isIppatsu;
    [FieldOffset(0x0E8)] public int WallTilesRemaining;
    [FieldOffset(0x0EC)] public int KanCount;
    [FieldOffset(0x0F0)] public int DoraIndicatorCount;
    /// <remarks>
    /// Tile kind, | 0x100 for a red five
    /// </remarks>
    [FieldOffset(0x0F4), FixedSizeArray] internal FixedSizeArray5<uint> _doraIndicators;
    [FieldOffset(0x108)] public int UraDoraIndicatorCount;
    [FieldOffset(0x10C), FixedSizeArray] internal FixedSizeArray5<uint> _uraDoraIndicators;
    /// <remarks>
    /// By position, 0 is first place
    /// </remarks>
    [FieldOffset(0x120), FixedSizeArray] internal FixedSizeArray4<int> _placements;
    /// <remarks>
    /// Positions ordered from first to last place
    /// </remarks>
    [FieldOffset(0x130), FixedSizeArray] internal FixedSizeArray4<int> _standings;
    /// <remarks>
    /// Copies of each tile kind not yet visible, starts at 4
    /// </remarks>
    [FieldOffset(0x160), FixedSizeArray] internal FixedSizeArray34<int> _unseenTileCounts;
    /// <remarks>
    /// Red copies of each tile kind in the set
    /// </remarks>
    [FieldOffset(0x1E8), FixedSizeArray] internal FixedSizeArray34<int> _redTileCounts;
    [FieldOffset(0x270), FixedSizeArray] internal FixedSizeArray34<int> _unseenRedTileCounts;
    [FieldOffset(0x314)] public int StartSeatOffset;

    [MemberFunction("E8 ?? ?? ?? ?? 4D 89 A5")]
    public partial RoundState* Ctor(void* rules, MeldList* meldLists, Board.DiscardPile* discardPiles);

    [MemberFunction("E8 ?? ?? ?? ?? 85 C0 74 ?? 48 8B CB E8 ?? ?? ?? ?? 41 8B C6")]
    public partial bool IsFinalHand();

    /// <param name="position">Position, 4 returns the table total</param>
    [MemberFunction("E8 ?? ?? ?? ?? 8B 54 24 ?? 44 8B E8")]
    public partial int GetRiichiSticks(uint position);

    [MemberFunction("E8 ?? ?? ?? ?? 44 8B 44 24 ?? 41 8B D7 48 8B CD")]
    public partial void DeclareRiichi(uint seat);

    [MemberFunction("E8 ?? ?? ?? ?? ?? ?? ?? ?? 49 8B CE 41 0F B7 54 24 ?? 48 69 F8")]
    public partial void CancelRiichi(uint seat);

    [MemberFunction("E8 ?? ?? ?? ?? 41 0F B7 54 24 ?? 8D 47")]
    public partial void ClearFirstTurn(uint seat, bool isRiichiDiscard);

    [MemberFunction("E8 ?? ?? ?? ?? 48 8B CD E8 ?? ?? ?? ?? 0F B7 D3 49 8B CE")]
    public partial void InterruptFirstTurn();

    [MemberFunction("E8 ?? ?? ?? ?? 8B 56 ?? 4C 8D 46")]
    public partial void DecodeDoraIndicators();

    [MemberFunction("E8 ?? ?? ?? ?? 0F B7 D6 49 8B CE")]
    public partial void AddKanDora(uint indicator, uint uraIndicator);

    [MemberFunction("E8 ?? ?? ?? ?? 41 8B C6 44 89 B3")]
    public partial void DistributeRiichiSticks();

    [MemberFunction("E8 ?? ?? ?? ?? 4C 8B 43 ?? 41 39 68")]
    public partial void UpdateStandings();

    /// <param name="positions">Receives 4 positions, first place first</param>
    [MemberFunction("E8 ?? ?? ?? ?? 44 8B CB 41 8B D1")]
    public partial void GetStandings(uint* positions);

    /// <param name="seats">Receives 4 seats, first place first</param>
    [MemberFunction("48 89 5C 24 ?? 57 48 83 EC ?? 48 8B FA 48 8B D9 E8 ?? ?? ?? ?? 8B 83 ?? ?? ?? ?? 2B 43")]
    public partial void GetStandingSeats(uint* seats);

    [MemberFunction("44 8B 81 ?? ?? ?? ?? 44 03 41 ?? 44 03 C2 41 83 E0 ?? 42 8B 84 81")]
    public partial int GetPlacement(uint seat);

    [MemberFunction("48 89 5C 24 ?? 48 89 6C 24 ?? 48 89 74 24 ?? 57 41 54 41 56 C7 81")]
    public partial void ResetUnseenTileCounts();

    [MemberFunction("E8 ?? ?? ?? ?? 41 8B D7 49 8B CE E8 ?? ?? ?? ?? E9 ?? ?? ?? ?? 41 8B D7")]
    public partial void RemoveUnseenTile(uint tile);

    [MemberFunction("E8 ?? ?? ?? ?? 49 8D AE ?? ?? ?? ?? EB")]
    public partial void ResetGame();

    [MemberFunction("E8 ?? ?? ?? ?? 33 F6 41 BE ?? ?? ?? ?? 0F 1F 84 00")]
    public partial void ResetHand();

    [MemberFunction("48 89 5C 24 ?? 44 8B 99")]
    public partial int CheckGameEnd();

    /// <returns>True when the game is over</returns>
    [MemberFunction("E8 ?? ?? ?? ?? 80 BB ?? ?? ?? ?? 00 74 ?? 48 8B 83 ?? ?? ?? ?? 83 B8")]
    public partial bool AdvanceRound();
}
