using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NeoNGhost.Items.Weapons
{
	public class GraniteRifle: ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Granite Rifle");
            Tooltip.SetDefault("Shoots a burst of foul darkness bullets");
        }
        public override void SetDefaults()
		{
			item.damage = 34;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 10;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 5;
            item.UseSound=new Terraria.Audio.LegacySoundStyle(2,31);
			item.autoReuse = true;
			item.shoot = 10; //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 16f;
			item.useAmmo = AmmoID.Bullet;
			item.useAnimation = 12;
			item.useTime = 4;
			item.reuseDelay = 14;
		}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-10, 3);
		}
		public override bool ConsumeAmmo(Player player)
		{
			// Because of how the game works, player.itemAnimation will be 11, 7, and finally 3. (UseAmination - 1, then - useTime until less than 0.) 
			// We can get the Clockwork Assult Riffle Effect by not consuming ammo when itemAnimation is lower than the first shot.
			return !(player.itemAnimation < item.useAnimation - 2);
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			if (type != mod.ProjectileType("EneriBullet")) // or ProjectileID.WoodenArrowFriendly
			{
				type = mod.ProjectileType("EneriBullet"); // or ProjectileID.FireArrow;
			}
			return true; // return true to allow tmodloader to call Projectile.NewProjectile as normal
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
