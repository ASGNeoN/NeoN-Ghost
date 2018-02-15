using Terraria.ID;
using Terraria.ModLoader;

namespace NeoNGhost.Items.Weapons
{
	public class GraniteChainsaw : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Granite Chainsaw");
            Tooltip.SetDefault("Heavy to hold and intimidating!");
        }
        public override void SetDefaults()
		{
			item.damage = 42;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 6;
			item.useAnimation = 25;
			item.useStyle = 5;
			item.knockBack = 4;
            item.channel = true;
            item.noUseGraphic = true;
            item.noMelee = true;
			item.value = 40000;
			item.rare = 5;
			item.axe = 22;
			item.tileBoost = +1;
            item.UseSound = SoundID.Item23;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("GraniteChainsaw");
			item.shootSpeed = 40f;
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
