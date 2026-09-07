using Mutagen.Bethesda.Synthesis.Settings;

namespace ReverbandAmbianceOverhaulPatcher
{
    public class Settings
    {
        [SynthesisSettingName("Source Plugin")]
        [SynthesisTooltip("Plugin to forward CELL XCAS Acoustic Space and Region Sound Chances from. Example: Reverb and Ambiance Overhaul - Skyrim.esp")]
        public string SourcePlugin { get; set; } = "Reverb and Ambiance Overhaul - Skyrim.esp";
    }
}
