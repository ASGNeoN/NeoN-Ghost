using Terraria.ID;
using Terraria.ModLoader;

namespace NeoNGhost.Items.Weapons
{
	public class EneriBullet : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Eneri Bullet");
            Tooltip.SetDefault("Douses enemies in vile flames");
        }
        public override void SetDefaults()
		{
			item.damage = 5;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			item.value = 100;
			item.rare = 5;
			item.shoot = mod.ProjectileType("EneriBullet");//The projectile shoot when your weapon using this ammo                //The speed of the projectile
			item.ammo = AmmoID.Bullet;  //The ammo class this ammo belongs to.
		}
		
		public override void AddRecipes()
		{
           ModRecipe recipe = new ModRecipe(mod);
           recipe.AddIngredient(ItemID.GraniteBlock, 50);
           recipe.AddIngredient(ItemID.DarkShard, 1);	 	
           recipe.AddIngredient(ItemID.SoulofNight, 1);		
           recipe.AddIngredient(ItemID.SoulofMight, 1);			   
           recipe.AddTile(TileID.MythrilAnvil);
           recipe.SetResult(this, 200);
           recipe.AddRecipe();
		}
		
	}
}
