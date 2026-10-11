using FFXIVClientStructs.FFXIV.Client.Game;
using FFXIVClientStructs.FFXIV.Client.UI.Misc;

namespace FFXIVClientStructs.FFXIV.Client.UI.Agent;

// Client::UI::Agent::AgentEmj
//   Client::UI::Agent::AgentInterface
//     Component::GUI::AtkModuleInterface::AtkEventInterface
[Agent(AgentId.Emj)]
[GenerateInterop]
[Inherits<AgentInterface>]
[StructLayout(LayoutKind.Explicit, Size = 0x40)]
public unsafe partial struct AgentEmj {
    /// <remarks>
    /// Allocated when the agent is shown
    /// </remarks>
    [FieldOffset(0x28)] public EmjGame* Game;
    /// <remarks>
    /// 0 = Solo match against NPCs, 1 = Online match (InstanceContentMahjong)
    /// </remarks>
    [FieldOffset(0x30)] public uint MatchType;

    // [MemberFunction("")]
    // public partial EmjEngine* GetEngine();

    // [MemberFunction("")]
    // public partial void OpenChiSelection();

    [MemberFunction("48 89 5C 24 ?? 48 89 6C 24 ?? 48 89 74 24 ?? 48 89 7C 24 ?? 41 56 48 83 EC ?? 48 8B E9 48 8B 49 ?? ?? ?? ?? FF 50 ?? 48 8B C8")]
    public partial void CreateGame();

    // Client::UI::Agent::AgentEmj::EmjCharaView
    //   Client::UI::Misc::CharaView
    [GenerateInterop]
    [Inherits<CharaView>]
    [StructLayout(LayoutKind.Explicit, Size = 0x330)]
    public partial struct EmjCharaView;

    // Client::UI::Agent::AgentEmj::EmjGame
    [GenerateInterop]
    [StructLayout(LayoutKind.Explicit, Size = 0xFB8)]
    public unsafe partial struct EmjGame {
        [FieldOffset(0x28), FixedSizeArray] internal FixedSizeArray4<Seat> _seats;

        [FieldOffset(0xF68)] public AgentEmj* Agent;
        [FieldOffset(0xF70)] public UIModule* UIModule;
        [FieldOffset(0xF80)] public EmjEngine* Engine;
        [FieldOffset(0xF8C)] public uint State;

        /// <remarks>
        /// Copied from EmjModule when the game is created, 0 if character voices are disabled
        /// </remarks>
        [FieldOffset(0xFA9)] public byte EmjVoiceNpc;
        /// <remarks>
        /// Copied from EmjModule when the game is created
        /// </remarks>
        [FieldOffset(0xFAB)] public byte EmjCostumeId;

        // [MemberFunction("")]
        // public partial EmjGame* Ctor(AgentEmj* agent, UIModule* uiModule);

        // [MemberFunction("")]
        // public partial CStringPointer GetEmjAddonText(uint rowId);

        // [MemberFunction("")]
        // public partial CStringPointer GetEmjAddonText2(uint rowId, int param);

        // [MemberFunction("")]
        // public partial CStringPointer GetEmjAddonText3(uint rowId, int param1, int param2);

        // [MemberFunction("")]
        // public partial void UpdateDangerMarkers();

        // [MemberFunction("")]
        // public partial void UpdateCallHint();

        // [MemberFunction("")]
        // public partial bool AutoPlaySeat(uint seat);

        // [MemberFunction("")]
        // public partial void UpdateResultYakuText(void* a2, void* a3);

        // Client::UI::Agent::AgentEmj::EmjGame::Seat
        [GenerateInterop]
        [StructLayout(LayoutKind.Explicit, Size = 0x338)]
        public unsafe partial struct Seat {
            [FieldOffset(0x000)] public EmjCharaView CharaView;
            [FieldOffset(0x330)] private uint Unk330; // set to 3 once the CharaView is ready
            [FieldOffset(0x334)] public byte SeatIndex;

            // [MemberFunction("")]
            // public partial Seat* Ctor();
        }
    }
}
