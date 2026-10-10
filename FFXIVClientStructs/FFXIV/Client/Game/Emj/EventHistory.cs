namespace FFXIVClientStructs.FFXIV.Client.Game.Emj;

// Client::Game::Emj::EventHistory
// ctor inlined in Table ctor
[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x1010)]
public unsafe partial struct EventHistory {
    [FieldOffset(0x0000), FixedSizeArray] internal FixedSizeArray200<GameEvent> _events;

    /// <remarks>
    /// Points to Table.Scores[0]
    /// </remarks>
    [FieldOffset(0x0FF8)] public Score* Score;
    [FieldOffset(0x1000)] public int EventCount;

    [MemberFunction("E8 ?? ?? ?? ?? 8B 4B ?? 8D 81")]
    public partial void ApplyEvent();
}
