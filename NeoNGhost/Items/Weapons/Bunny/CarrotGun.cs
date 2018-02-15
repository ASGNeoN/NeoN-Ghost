using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NeoNGhost.Items.Weapons.Bunny
{
	public class CarrotGun: ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Carrot Gun");
            Tooltip.SetDefault("Enemies hit will be 'Bunboozled'");
        }

        public override void SetDefaults()
		{
			item.damage = 20;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 4;
			item.value = 100000;
            item.rare = 1;
            item.UseSound=new Terraria.Audio.LegacySoundStyle(2,11);
			item.autoReuse = true;
			item.shoot = 10; //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 8f;
			item.useAmmo = AmmoID.Bullet;
			item.useAnimation = 21;
			item.useTime = 21;
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			if (type != mod.ProjectileType("Carrot")) // or ProjectileID.WoodenArrowFriendly
			{
				type = mod.ProjectileType("Carrot"); // or ProjectileID.FireArrow;
			}
			return true; // return true to allow tmodloader to call Projectile.NewProjectile as normal
		}
	}
}
