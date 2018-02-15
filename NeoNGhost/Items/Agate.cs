using Terraria.ID;
using Terraria.ModLoader;

namespace NeoNGhost.Items
{
	public class Agate : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Agate");
            Tooltip.SetDefault("Infused with plants' energies.");
        }

        Mod Thorium = ModLoader.GetMod("ThoriumMod");
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 500;
			item.rare = 1;
		}
		public override void AddRecipes()
	{
            ModRecipe recipe = new ModRecipe(mod);
          recipe.AddIngredient(mod, "EmeraldDust", 2);
          recipe.AddIngredient(ItemID.RichMahogany, 2);
          recipe.AddTile(null, "Crystallizer");
           recipe.SetResult(this);
		recipe.AddRecipe();
		} 
	}
}
