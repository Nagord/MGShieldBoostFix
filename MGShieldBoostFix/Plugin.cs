using PulsarPluginLoader;

namespace MGShieldBoostFix
{
    public class Plugin : PulsarPlugin
    {
        public override string Version => "1.0.0";

        public override string Author => "Dragon";

        public override string LongDescription => "Fixes the dev's mistake";

        public override string Name => "MGShieldBoostFix";

        public override string HarmonyIdentifier()
        {
            return "Dragon.MGShieldBoostFix";
        }
    }
}
