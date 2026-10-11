using FFXIVClientStructs.FFXIV.Client.Game.Emj;
using FFXIVClientStructs.FFXIV.Client.UI.Agent;

namespace FFXIVClientStructs.FFXIV.Client.Game;

// Client::Game::EmjEngineCore
[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x4E0)]
public unsafe partial struct EmjEngineCore {
    /// <remarks>
    /// The client side state of the match, present in both solo and online matches
    /// </remarks>
    [FieldOffset(0x468)] public ClientTable* Table;
    /// <remarks>
    /// Copy of the last action decided by the AI (see <see cref="Emj.Table.AiAction"/>)
    /// </remarks>
    [FieldOffset(0x470)] public GameEvent AiAction;
    /// <remarks>
    /// Only present in solo matches
    /// </remarks>
    [FieldOffset(0x4B8)] public EmjLocalEngine* LocalEngine;
    [FieldOffset(0x4D0)] public AgentEmj.EmjGame* Game;

    [MemberFunction("E8 ?? ?? ?? ?? 48 89 43 ?? 48 8B C3 48 8B 5C 24 ?? 48 8B 74 24 ?? 48 83 C4 ?? 5F C3 48 8B 74 24")]
    public partial EmjEngineCore* Ctor(EmjEngine* engine, void* callback, bool isSolo);
}
