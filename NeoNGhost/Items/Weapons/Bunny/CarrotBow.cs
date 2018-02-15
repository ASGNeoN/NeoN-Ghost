using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NeoNGhost.Items.Weapons.Bunny
{
	public class CarrotBow: ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Carrot Bow");
            Tooltip.SetDefault("Enemies hit will be 'Bunboozled'");
        }
        public override void SetDefaults()
		{
			item.damage = 20;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
            item.useTime = 30;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 4;
			item.value = 100000;
            item.rare = 1; 
            item.UseSound=new Terraria.Audio.LegacySoundStyle(2,5);
			item.autoReuse = true;
			item.shoot = 10; //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 8f;
			item.useAmmo = AmmoID.Arrow;
			item.useAnimation = 30;
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			if (type != mod.ProjectileType("Carrow")) // or ProjectileID.WoodenArrowFriendly
			{
				type = mod.ProjectileType("Carrow"); // or ProjectileID.FireArrow;
			}
            return true;
		}
	}
}
