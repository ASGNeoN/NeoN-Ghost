using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace NeoNGhost.Items.Weapons
{
	public class GrappleGun : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Grapple Gun");
            Tooltip.SetDefault("Allows to grapple to walls and also to attack enemies!");
        }
        public override void SetDefaults()
		{
			item.damage = 20;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 16;
			item.useAnimation = 16;
			item.useStyle = 5;
			item.knockBack = 4;
            item.noMelee = true;
			item.value = 400;
			item.rare = 2;
            item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = Terraria.ID.ExtrasID.ForbiddenSign;
			item.shootSpeed = 20f;
		}
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int p = Projectile.NewProjectile(position, new Vector2(speedX, speedY), type, damage, knockBack, item.owner);
            Projectile pro = Main.projectile[p];
            pro.ranged = true;
            return false;
        }
        public override void AddRecipes()
		{
           ModRecipe recipe = new ModRecipe(mod);
           recipe.AddIngredient(ItemID.Harpoon);
           recipe.AddIngredient(ItemID.GrapplingHook);	 		   
           recipe.AddTile(TileID.Anvils);
           recipe.SetResult(this);
           recipe.AddRecipe();
		}
        public override bool CanUseItem(Player player)
        {
            return player.ownedProjectileCounts[item.shoot] < 1; // This is to ensure the spear doesn't bug out when using autoReuse = true
        }

    }
}
