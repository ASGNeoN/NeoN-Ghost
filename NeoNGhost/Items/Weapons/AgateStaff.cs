using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NeoNGhost.Items.Weapons
{
	public class AgateStaff : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Agate Staff");
            Tooltip.SetDefault("Casts sharp leaves!");
        }

        public override void SetDefaults()
        {
            item.magic = true;
			item.autoReuse = true;
			item.useTime = 31;
			item.useAnimation = 31;
			item.mana = 6;
			item.damage = 19;
			item.shoot = 206;
            item.crit = 11;
			item.width = 40;
			item.height = 40;
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 4;
			item.value = 3000;
			item.rare = 1;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shootSpeed = 8f;
			item.useStyle = 5;
        }
		
		
	    public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "Agate", 8);
            recipe.AddIngredient(ItemID.RichMahogany, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}
