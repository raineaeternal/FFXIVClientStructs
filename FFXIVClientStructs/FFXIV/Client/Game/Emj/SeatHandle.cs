namespace FFXIVClientStructs.FFXIV.Client.Game.Emj;

// Client::Game::Emj::SeatHandle
// ctor inlined in Table ctor
[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe partial struct SeatHandle {
    [MemberFunction("E8 ?? ?? ?? ?? 8B C0 C6 44 18")]
    public partial uint GetSeat();

    [MemberFunction("E8 ?? ?? ?? ?? 48 8B F8 83 EE")]
    public partial PlayerHandle* GetPlayerHandle();
}
