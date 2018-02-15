using Terraria.ID;
using Terraria.ModLoader;

namespace NeoNGhost.Items.Compatibility
{
    public class MSlimeGun : ModItem
    {
        Mod CW = ModLoader.GetMod("ConvertedWeapons");

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Slime Gun");
            Tooltip.SetDefault("Moved to Converted Weapons.");
        }

        public override void AddRecipes()
        {
            if (CW != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(this);
                recipe.SetResult(ModLoader.GetMod("ConvertedWeapons").ItemType("MSlimeGun"));
                recipe.AddRecipe();
            }
        }
    }
}
