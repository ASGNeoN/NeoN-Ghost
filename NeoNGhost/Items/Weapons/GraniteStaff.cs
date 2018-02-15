using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NeoNGhost.Items.Weapons
{
	public class GraniteStaff : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Granite Staff");
            Tooltip.SetDefault("Casts a foul dark crystal");
        }

        public override void SetDefaults()
        {
            item.magic = true;
			item.autoReuse = true;
			item.useTime = 19;
			item.useAnimation = 19;
			item.mana = 10;
			item.damage = 46;
			item.shoot = 661;
			item.width = 40;
			item.height = 40;
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 5;
			item.value = 40000;
			item.rare = 5;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shootSpeed = 16f;
			item.useStyle = 5;
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
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
            int p = Projectile.NewProjectile(position, new Vector2(speedX, speedY), type, damage, knockBack, item.owner);
            Projectile pro = Main.projectile[p];
            pro.ranged = false;
            pro.magic = true;
            Lighting.AddLight(position, (float)0.05, 0, (float)0.1);
            return false;
		}
	}
}
