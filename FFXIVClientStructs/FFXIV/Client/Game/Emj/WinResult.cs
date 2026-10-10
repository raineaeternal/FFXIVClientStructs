namespace FFXIVClientStructs.FFXIV.Client.Game.Emj;

// Client::Game::Emj::WinResult
// ctor inlined in Player.Initialize
[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x2700)]
public unsafe partial struct WinResult {
    /// <remarks>
    /// Highest scoring entry of Candidates, copied by FindBestHand
    /// </remarks>
    [FieldOffset(0x010)] public Candidate BestCandidate;
    [FieldOffset(0x2A8)] public int CandidateCount;
    [FieldOffset(0x2B0), FixedSizeArray] internal FixedSizeArray14<Candidate> _candidates;

    [MemberFunction("E8 ?? ?? ?? ?? 41 8B C6 48 8B 5C 24 ?? 48 8B 6C 24")]
    public partial void AddCandidate();

    [MemberFunction("E8 ?? ?? ?? ?? 85 C0 74 ?? 48 8B 5C 24")]
    public partial void FindBestHand();

    /// <remarks>
    /// One way to read the winning hand, filled by WinAnalyzer
    /// </remarks>
    [GenerateInterop]
    [StructLayout(LayoutKind.Explicit, Size = 0x298)]
    public partial struct Candidate {
        /// <remarks>
        /// 1 = Seven Pairs, 2 = Thirteen Orphans, 3 = Thirteen Orphans (13-sided wait), 5 = Shiisan Puutaa
        /// </remarks>
        [FieldOffset(0x024)] public int Form;
        /// <remarks>
        /// 4 melds and the pair
        /// </remarks>
        [FieldOffset(0x038), FixedSizeArray] internal FixedSizeArray5<Meld> _melds;
        /// <remarks>
        /// 1 = Ryanmen, 2 = Kanchan, 4 = Penchan, 8 = Shanpon, 16 = Tanki, 32 = Seven Pairs, 64 = Thirteen Orphans, 128 = Thirteen Orphans (13-sided wait), 512 = Shiisan Puutaa
        /// </remarks>
        [FieldOffset(0x1F4)] public uint WaitType;
    }
}
