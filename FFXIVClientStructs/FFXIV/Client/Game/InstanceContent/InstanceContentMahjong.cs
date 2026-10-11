using FFXIVClientStructs.FFXIV.Client.Game.UI;

namespace FFXIVClientStructs.FFXIV.Client.Game.InstanceContent;

// Client::Game::InstanceContent::InstanceContentMahjong
//   Client::Game::InstanceContent::InstanceContentDirector
//     Client::Game::InstanceContent::ContentDirector
//       Client::Game::Event::Director
//         Client::Game::Event::LuaEventHandler
//           Client::Game::Event::EventHandler
// ctor "48 89 5C 24 08 48 89 6C 24 10 48 89 74 24 18 48 89 7C 24 20 41 56 48 83 EC 20 48 8B F1 E8 ?? ?? ?? ?? 48 8D 05 ?? ?? ?? ?? BF 04 00 00 00"
[GenerateInterop]
[Inherits<InstanceContentDirector>]
[StructLayout(LayoutKind.Explicit, Size = 0x21C0)]
public unsafe partial struct InstanceContentMahjong {
    [FieldOffset(0x1FA0), FixedSizeArray] internal FixedSizeArray4<MahjongPlayerInfo> _players;

    [FieldOffset(0x21B0)] private uint Unk21B0; // set by ActorControl 0x7D0 type 3
    /// <remarks>
    /// Set by ActorControl 0x7D0 type 4.<br/>
    /// 0 = New hands can still be started (see <see cref="NewHandDeadline"/>), 1 = One hand remaining, 2 = Final hand
    /// </remarks>
    [FieldOffset(0x21B4)] public uint HandLimitState;
    /// <remarks>
    /// Set by ActorControl 0x7D0 type 4.<br/>
    /// Unix timestamp, shown as "Time remaining until new hand"
    /// </remarks>
    [FieldOffset(0x21B8)] public uint NewHandDeadline;

    [MemberFunction("48 89 5C 24 ?? 48 89 6C 24 ?? 48 89 74 24 ?? 48 89 7C 24 ?? 41 56 48 83 EC ?? 48 8B F1 E8 ?? ?? ?? ?? 48 8D 05 ?? ?? ?? ?? BF ?? ?? ?? ?? ?? ?? ?? 48 8D 9E ?? ?? ?? ?? 48 8D 05")]
    public partial InstanceContentMahjong* Ctor();

    [MemberFunction("E8 ?? ?? ?? ?? E9 ?? ?? ?? ?? F3 0F 10 4C 24")]
    public partial void HandleActorControl(int type, uint param1, uint param2);

    [MemberFunction("E8 ?? ?? ?? ?? 8B 4B ?? 39 48")]
    public partial MahjongPlayerInfo* GetPlayerInfo(uint seat);

    [MemberFunction("E8 ?? ?? ?? ?? 85 C0 74 ?? 83 E8 ?? 74 ?? 83 F8 ?? 0F 85 ?? ?? ?? ?? 8D 50 ?? 48 8B CF 44 8D 40 ?? E8 ?? ?? ?? ?? E9 ?? ?? ?? ?? BA ?? ?? ?? ?? 48 8B CF 44 8D 42 ?? E8 ?? ?? ?? ?? EB ?? 48 8B CB E8 ?? ?? ?? ?? 8B D8 E8 ?? ?? ?? ?? 2B D8 45 8B C5")]
    public partial uint GetHandLimitState();

    [MemberFunction("E8 ?? ?? ?? ?? 8B D8 E8 ?? ?? ?? ?? 2B D8 45 8B C5")]
    public partial uint GetNewHandDeadline();

    [StructLayout(LayoutKind.Explicit, Size = 0x84)]
    public struct MahjongPlayerInfo {
        [FieldOffset(0x4C)] public BannerData BannerData;
    }
}
