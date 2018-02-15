using Terraria.ID;
using Terraria.ModLoader;

namespace NeoNGhost.Items.Compatibility
{
    public class MBeamSword : ModItem
    {
        Mod CW = ModLoader.GetMod("ConvertedWeapons");

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Beam Sword");
            Tooltip.SetDefault("Moved to Converted Weapons.");
        }

        public override void AddRecipes()
        {
            if (CW != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(this);
                recipe.SetResult(ModLoader.GetMod("ConvertedWeapons").ItemType("MBeamSword"));
                recipe.AddRecipe();
            }
        }
    }
}
