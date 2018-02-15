using Terraria.ID;
using Terraria.ModLoader;

namespace NeoNGhost.Items.Weapons
{
	public class GraniteGreatsword : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Granite Greatsword");
            Tooltip.SetDefault("Heavy to hold and intimidating!");
        }
        public override void SetDefaults()
		{
			item.damage = 65;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 33;
			item.useAnimation = 33;
			item.useTurn = true;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 43000;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
		public override void AddRecipes()
		{
           ModRecipe recipe = new ModRecipe(mod);
           recipe.AddIngredient(ItemID.GraniteBlock, 50);
           recipe.AddIngredient(ItemID.DarkShard, 2);	 	
           recipe.AddIngredient(ItemID.SoulofNight, 5);		
           recipe.AddIngredient(ItemID.SoulofFright, 5);			   
           recipe.AddTile(TileID.MythrilAnvil);
           recipe.SetResult(this);
           recipe.AddRecipe();
		}

	}
}
