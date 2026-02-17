using BepInEx;
using HarmonyLib;

namespace BetterInstrumentPlaying;

[BepInPlugin(Constants.ModId, Constants.ModName, Constants.ModVersion)]
public class Plugin : BaseUnityPlugin
{
    private void Start()
    {
        var harmony = new Harmony(Constants.ModId);
        harmony.PatchAll();
    }
}
