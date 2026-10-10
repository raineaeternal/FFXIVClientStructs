namespace FFXIVClientStructs.FFXIV.Client.Game.Emj;

// Client::Game::Emj::LocalTable
//   Client::Game::Emj::Table
// ctor "48 89 5C 24 08 48 89 6C 24 10 48 89 74 24 18 57 41 54 41 55 41 56 41 57 48 83 EC 30 4D 8B F8 4C 8B E2"
// Only used in solo matches, see EmjLocalEngine
[GenerateInterop]
[Inherits<Table>]
[StructLayout(LayoutKind.Explicit, Size = 0x17E0)]
public unsafe partial struct LocalTable {
    [FieldOffset(0x17C0)] public EmjLocalEngine* LocalEngine;

    [MemberFunction("E8 ?? ?? ?? ?? 48 89 43 ?? 48 8B C3 48 8B 5C 24 ?? 48 83 C4")]
    public partial LocalTable* Ctor();
}
