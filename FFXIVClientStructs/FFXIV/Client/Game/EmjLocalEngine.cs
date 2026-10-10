using FFXIVClientStructs.FFXIV.Client.Game.Emj;

namespace FFXIVClientStructs.FFXIV.Client.Game;

// Client::Game::EmjLocalEngine
// Simulates the server side of the match in solo matches
[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x18)]
public unsafe partial struct EmjLocalEngine {
    [FieldOffset(0x10)] public LocalTable* Table;
}
