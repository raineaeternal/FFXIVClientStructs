using FFXIVClientStructs.FFXIV.Client.Game.Emj;

namespace FFXIVClientStructs.FFXIV.Client.Game;

// Client::Game::EmjLocalEngine
// Simulates the server side of the match in solo matches
[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x18)]
public unsafe partial struct EmjLocalEngine {
    [FieldOffset(0x10)] public LocalTable* Table;

    [MemberFunction("E8 ?? ?? ?? ?? B9 ?? ?? ?? ?? E8 ?? ?? ?? ?? 8B D0")]
    public partial void SetStartSeat(int seat);

    [MemberFunction("E8 ?? ?? ?? ?? 48 8B 8F ?? ?? ?? ?? 40 88 B7 ?? ?? ?? ?? 40 88 B7")]
    public partial void SetSeed(int seed);
}
