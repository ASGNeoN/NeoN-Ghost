using Terraria.ID;
using Terraria.ModLoader;

namespace NeoNGhost.Items.Weapons
{
	public class GraniteWarhammer : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Granite Warhammer");
            Tooltip.SetDefault("Heavy to hold and intimidating!");
        }
        public override void SetDefaults()
		{
			item.damage = 62;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 13;
			item.useTurn = true;
			item.useAnimation = 34;
			item.useStyle = 1;
			item.knockBack = 8;
			item.value = 31200;
			item.rare = 5;
			item.hammer = 85;
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
