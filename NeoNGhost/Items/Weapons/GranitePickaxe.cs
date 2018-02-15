using Terraria.ID;
using Terraria.ModLoader;

namespace NeoNGhost.Items.Weapons
{
	public class GranitePickaxe : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Granite Pickaxe");
            Tooltip.SetDefault("While it seems heavy it's actually pretty nimble.");
        }
        public override void SetDefaults()
		{
			item.damage = 34;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 7;
			item.useTurn = true;
			item.useAnimation = 24;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 57400;
			item.rare = 5;
			item.pick = 195;
			item.tileBoost = +1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
		public override void AddRecipes()
		{
           ModRecipe recipe = new ModRecipe(mod);
           recipe.AddIngredient(ItemID.GraniteBlock, 50);
           recipe.AddIngredient(ItemID.DarkShard, 2);	 	
           recipe.AddIngredient(ItemID.SoulofNight, 5);		
           recipe.AddIngredient(ItemID.SoulofMight, 5);			   
           recipe.AddTile(TileID.MythrilAnvil);
           recipe.SetResult(this);
           recipe.AddRecipe();
		}

	}
}
