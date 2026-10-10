namespace FFXIVClientStructs.FFXIV.Client.Game.Emj;

// Client::Game::Emj::ClientTable
//   Client::Game::Emj::Table
// ctor inlined in EmjEngineCore ctor
[GenerateInterop]
[Inherits<Table>]
[StructLayout(LayoutKind.Explicit, Size = 0x1420)]
public unsafe partial struct ClientTable {
    /// <remarks>
    /// Seat index of the local player, 4 if not set
    /// </remarks>
    [FieldOffset(0x1418)] public uint LocalSeat;
}
