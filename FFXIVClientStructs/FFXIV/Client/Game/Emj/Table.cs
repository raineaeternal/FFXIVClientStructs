namespace FFXIVClientStructs.FFXIV.Client.Game.Emj;

// Client::Game::Emj::Table
// ctor "48 89 5C 24 10 44 88 44 24 18 55 56 57 41 54 41 55 41 56 41 57 48 81 EC 90 00 00 00"
[GenerateInterop(isInherited: true)]
[StructLayout(LayoutKind.Explicit, Size = 0x1418)]
public unsafe partial struct Table {
    [FieldOffset(0x0008), FixedSizeArray] internal FixedSizeArray4<Player> _players;
    [FieldOffset(0x0E28), FixedSizeArray] internal FixedSizeArray4<PlayerHandle> _playerHandles;
    [FieldOffset(0x0E68), FixedSizeArray] internal FixedSizeArray4<SeatHandle> _seatHandles;
    [FieldOffset(0x0EA8), FixedSizeArray] internal FixedSizeArray3<Score> _scores;

    [FieldOffset(0x12C0)] public Board* Board;
    /// <remarks>
    /// Tile drawn by the seat whose turn it is, PlayerHandle.GetDrawnTile returns its Tile for that seat and 255 for the others
    /// </remarks>
    [FieldOffset(0x1350)] public TileInfo DrawnTile;
    /// <remarks>
    /// Most recent discard, also appended to Board.DiscardPiles
    /// </remarks>
    [FieldOffset(0x136C)] public TileInfo LastDiscard;

    [FieldOffset(0x13E8)] public EventHistory* EventHistory;
    /// <remarks>
    /// Written when the AI decides an action for a seat
    /// </remarks>
    [FieldOffset(0x13F0)] public GameEvent AiAction;

    [MemberFunction("48 89 5C 24 ?? 44 88 44 24 ?? 55 56 57 41 54 41 55 41 56 41 57 48 81 EC")]
    public partial Table* Ctor(void* a2, bool a3);

    [MemberFunction("48 89 5C 24 ?? 44 89 44 24 ?? 48 89 54 24 ?? 55 56 57 41 54")]
    public partial void BuildWinResult(void* result, uint seat, bool a4, int a5);

    [MemberFunction("FF C9 83 F9 ?? 0F 87 ?? ?? ?? ?? 48 8D 15")]
    public static partial int GetYakuDisplayId(int yakuId);
}
