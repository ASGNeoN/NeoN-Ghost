using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NeoNGhost.Items.Weapons.Bunny
{
	public class CarrotStaff : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Carrot Staff");
            Tooltip.SetDefault("Enemies hit will be 'Bunboozled'");
        }

        public override void SetDefaults()
        {
            item.magic = true;
			item.autoReuse = true;
			item.useTime = 31;
			item.useAnimation = 31;
			item.mana = 6;
			item.damage = 19;
            item.shoot = mod.ProjectileType("Carrot");
            item.width = 40;
			item.height = 40;
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 4;
			item.value = 100000;
			item.rare = 1;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shootSpeed = 8f;
			item.useStyle = 5;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int p = Projectile.NewProjectile(position, new Vector2(speedX, speedY), type, damage, knockBack, item.owner);
            Projectile pro = Main.projectile[p];
            pro.ranged = false;
            pro.magic = true;
            return false;
        }

    }
}
