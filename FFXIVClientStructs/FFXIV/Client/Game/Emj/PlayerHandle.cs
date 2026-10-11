namespace FFXIVClientStructs.FFXIV.Client.Game.Emj;

// Client::Game::Emj::PlayerHandle
// ctor inlined in Table ctor
[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe partial struct PlayerHandle {

    [MemberFunction("E8 ?? ?? ?? ?? 8B D8 83 F8 ?? 7C ?? 83 EB ?? EB ?? 33 DB")]
    public partial int GetHandTileDangerLevel(int handIndex);

    [MemberFunction("E8 ?? ?? ?? ?? 33 DB 88 46")]
    public partial int GetHandTileCount();

    [MemberFunction("E8 ?? ?? ?? ?? 3D ?? ?? ?? ?? 74 ?? 49 8B CF")]
    public partial uint GetDrawnTile();

    [MemberFunction("E8 ?? ?? ?? ?? 8B D8 83 F8 ?? 7C ?? 83 EB ?? EB ?? 8B DE")]
    public partial int GetDrawnTileDangerLevel();
}
