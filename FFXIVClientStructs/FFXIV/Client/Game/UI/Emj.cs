namespace FFXIVClientStructs.FFXIV.Client.Game.UI;

// Client::Game::UI::Emj
// Doman Mahjong
[StructLayout(LayoutKind.Explicit, Size = 0x38)]
public struct Emj {
    [FieldOffset(0x00)] public ushort MatchesPlayed;
    [FieldOffset(0x02)] public ushort CurrentRating;
    [FieldOffset(0x04)] public ushort HighestRating;
    [FieldOffset(0x06)] public ushort RankPoints;
    /// <remarks>
    /// This is the row id of EmjDani
    /// </remarks>
    [FieldOffset(0x08)] public byte Rank;
    /// <remarks>
    /// Set once the data has been received from the server
    /// </remarks>
    [FieldOffset(0x09)] public bool IsLoaded;
}
