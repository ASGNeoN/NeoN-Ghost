using Terraria.ID;
using Terraria.ModLoader;

namespace NeoNGhost.Items.Compatibility
{
    public class MFlyingDragon : ModItem
    {
        Mod CW = ModLoader.GetMod("ConvertedWeapons");

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Flying Dragon");
            Tooltip.SetDefault("Moved to Converted Weapons.");
        }

        public override void AddRecipes()
        {
            if (CW != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(this);
                recipe.SetResult(ModLoader.GetMod("ConvertedWeapons").ItemType("MFlyingDragon"));
                recipe.AddRecipe();
            }
        }
    }
}
