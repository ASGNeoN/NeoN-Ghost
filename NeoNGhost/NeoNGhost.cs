using Terraria.ModLoader;

namespace NeoNGhost
{
	class NeoNGhost : Mod
    {
        public override void Load()
        {
            ModTranslation text = CreateTranslation("RainOn");
            text.SetDefault("It's starting to rain!");
            AddTranslation(text);
            text = CreateTranslation("RainOff");
            text.SetDefault("The rain stopped...");
            AddTranslation(text);
            text = CreateTranslation("SandOn");
            text.SetDefault("Powerful winds are starting to blow!");
            AddTranslation(text);
            text = CreateTranslation("SandOff");
            text.SetDefault("The powerful winds have stopped...");
            AddTranslation(text);
            text = CreateTranslation("ExpertOn");
            text.SetDefault("The Forces of Terraria have strengthened...");
            AddTranslation(text);
            text = CreateTranslation("ExpertOff");
            text.SetDefault("The Forces of Terraria have weakened...");
            AddTranslation(text);
        }
        public NeoNGhost()
		{
        Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };

    }
	}
}
