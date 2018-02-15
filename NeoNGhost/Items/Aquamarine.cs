using Terraria.ID;
using Terraria.ModLoader;

namespace NeoNGhost.Items
{

	public class Aquamarine : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Aquamarine");
            Tooltip.SetDefault("Infused with tidal strength.");
        }

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
           recipe.AddIngredient(mod, "SapphireDust", 4);
           recipe.AddIngredient(ItemID.Coral);
           recipe.AddTile(null, "Crystallizer");
           recipe.SetResult(this, 2);
            recipe.AddRecipe();
          }
    }
}
