namespace FFXIVClientStructs.FFXIV.Client.Game.Emj;

// Client::Game::Emj::YakuEvaluator
// created on the stack in WinResult.FindBestHand
[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x230)]
public unsafe partial struct YakuEvaluator {
    [FieldOffset(0x208)] public WinResult.Candidate* Candidate;
    [FieldOffset(0x210)] public Player* Player;
}
