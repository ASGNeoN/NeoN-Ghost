using Terraria.ID;
using Terraria.ModLoader;

namespace NeoNGhost.Items
{
	public class Crystallizer : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crystallizer");
            Tooltip.SetDefault("Used to crystallize powdered gems");
        }
        public override void SetDefaults()
		{
			item.width = 28;
			item.height = 14;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
			item.createTile = mod.TileType("Crystallizer");
		}
        public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar,15);	
			recipe.AddIngredient(ItemID.WaterBucket);	
			recipe.AddIngredient(ItemID.WhiteString);				
            recipe.AddTile(TileID.Anvils);	
			recipe.SetResult(this);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LeadBar,15);	
			recipe.AddIngredient(ItemID.WaterBucket);	
			recipe.AddIngredient(ItemID.WhiteString);				
            recipe.AddTile(TileID.Anvils);	
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}