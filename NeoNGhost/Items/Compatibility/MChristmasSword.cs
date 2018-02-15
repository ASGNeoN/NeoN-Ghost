using Terraria.ID;
using Terraria.ModLoader;

namespace NeoNGhost.Items.Compatibility
{
    public class MChristmasSword : ModItem
    {
        Mod CW = ModLoader.GetMod("ConvertedWeapons");

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Christmas Tree Sword");
            Tooltip.SetDefault("Moved to Converted Weapons.");
        }

        public override void AddRecipes()
        {
            if (CW != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(this);
                recipe.SetResult(ModLoader.GetMod("ConvertedWeapons").ItemType("MChristmasSword"));
                recipe.AddRecipe();
            }
        }
    }
}
