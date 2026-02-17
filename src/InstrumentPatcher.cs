using HarmonyLib;

namespace BetterInstrumentPlaying;

[HarmonyPatch(typeof(AIAct))]
public class InstrumentPatcher
{
    [HarmonyPrefix]
    [HarmonyPatch(nameof(AIAct.Do))]
    static void PlayMusic_Prefix(AIAct __instance)
    {
        if (__instance is not AI_PlayMusic playMusic)
            return;
        playMusic.playing?.mistakes = 0;
    }
}