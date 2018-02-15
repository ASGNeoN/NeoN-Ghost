using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NeoNGhost.Items.Compatibility
{
	public class LaserBullet : ModItem
	{
        Mod CW = ModLoader.GetMod("ConvertedWeapons");
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Laser Bullet");
            Tooltip.SetDefault("Moved to Converted Weapons.");
        }
        public override void SetDefaults()
        {
            item.maxStack = 999;
        }
        public override void AddRecipes()
		{
            if (CW != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(this);
                recipe.SetResult(ModLoader.GetMod("ConvertedWeapons").ItemType("LaserBullet"));
                recipe.AddRecipe();
            }
		}
		
	}
}
