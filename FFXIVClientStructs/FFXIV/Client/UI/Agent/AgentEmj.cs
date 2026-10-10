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

        // Client::UI::Agent::AgentEmj::EmjGame::Seat
        [StructLayout(LayoutKind.Explicit, Size = 0x338)]
        public struct Seat {
            [FieldOffset(0x000)] public EmjCharaView CharaView;
            [FieldOffset(0x330)] private uint Unk330; // set to 3 once the CharaView is ready
            [FieldOffset(0x334)] public byte SeatIndex;
        }
    }
}
