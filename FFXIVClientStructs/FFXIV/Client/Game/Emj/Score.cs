namespace FFXIVClientStructs.FFXIV.Client.Game.Emj;

// Client::Game::Emj::Score
// ctor inlined in Table ctor
[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0xA0)]
public unsafe partial struct Score {
    [MemberFunction("E8 ?? ?? ?? ?? 48 8B CF E9 ?? ?? ?? ?? 81 F9")]
    public partial void SettleWin();

    [MemberFunction("E8 ?? ?? ?? ?? 48 8B CF E9 ?? ?? ?? ?? 49 8B 86")]
    public partial void SettleExhaustiveDraw();
}
