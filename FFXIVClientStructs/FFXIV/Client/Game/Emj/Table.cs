namespace FFXIVClientStructs.FFXIV.Client.Game.Emj;

// Client::Game::Emj::Table
// ctor "48 89 5C 24 10 44 88 44 24 18 55 56 57 41 54 41 55 41 56 41 57 48 81 EC 90 00 00 00"
[GenerateInterop(isInherited: true)]
[StructLayout(LayoutKind.Explicit, Size = 0x1418)]
public unsafe partial struct Table {
    [FieldOffset(0x0008), FixedSizeArray] internal FixedSizeArray4<Player> _players;

    [FieldOffset(0x12C0)] public Board* Board;

    [FieldOffset(0x13E8)] public EventHistory* EventHistory;
    /// <remarks>
    /// Written when the AI decides an action for a seat
    /// </remarks>
    [FieldOffset(0x13F0)] public GameEvent AiAction;
}
