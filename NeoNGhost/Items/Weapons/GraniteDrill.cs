using Terraria.ID;
using Terraria.ModLoader;

namespace NeoNGhost.Items.Weapons
{
	public class GraniteDrill : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Granite Drill");
            Tooltip.SetDefault("Heavy to hold but still easy to use!");
        }
        public override void SetDefaults()
		{
			item.damage = 31;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 6;
			item.useAnimation = 22;
			item.useStyle = 5;
			item.knockBack = 6;
            item.channel = true;
            item.noUseGraphic = true;
            item.noMelee = true;
			item.value = 30000;
			item.rare = 5;
			item.pick = 195;
			item.tileBoost = +1;
            item.UseSound = SoundID.Item23;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("GraniteDrill");
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
