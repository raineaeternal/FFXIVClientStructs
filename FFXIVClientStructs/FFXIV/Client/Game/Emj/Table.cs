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

    [FieldOffset(0x13E8)] public EventHistory* EventHistory;
    /// <remarks>
    /// Written when the AI decides an action for a seat
    /// </remarks>
    [FieldOffset(0x13F0)] public GameEvent AiAction;

    [MemberFunction("48 89 5C 24 ?? 44 88 44 24 ?? 55 56 57 41 54 41 55 41 56 41 57 48 81 EC")]
    public partial Table* Ctor();

    [MemberFunction("48 89 5C 24 ?? 44 89 44 24 ?? 48 89 54 24 ?? 55 56 57 41 54")]
    public partial void BuildWinResult();

    [MemberFunction("FF C9 83 F9 ?? 0F 87 ?? ?? ?? ?? 48 8D 15")]
    public partial void GetYakuDisplayId();
}
