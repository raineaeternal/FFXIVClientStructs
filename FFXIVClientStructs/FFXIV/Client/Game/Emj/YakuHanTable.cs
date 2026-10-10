namespace FFXIVClientStructs.FFXIV.Client.Game.Emj;

// Client::Game::Emj::YakuHanTable
[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x128)]
public unsafe partial struct YakuHanTable {
    /// <remarks>
    /// Han per yaku, GetHan maps the internal yaku id to an index
    /// </remarks>
    [FieldOffset(0x00), FixedSizeArray] internal FixedSizeArray74<uint> _han;

    [MemberFunction("E8 ?? ?? ?? ?? 48 89 5F ?? 89 5F")]
    public partial void GetHan();
}
