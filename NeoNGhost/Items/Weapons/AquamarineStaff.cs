using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NeoNGhost.Items.Weapons
{
	public class AquamarineStaff : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Aquamarine Staff");
            Tooltip.SetDefault("Casts sparkly bubbles!");
        }
        public override void SetDefaults()
        {
            item.magic = true;
			item.autoReuse = true;
			item.useTime = 20;
			item.useAnimation = 20;
			item.mana = 3;
			item.damage = 9;
			item.shoot = 410;
			item.width = 40;
			item.height = 40;
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 1;
			item.value = 3000;
			item.rare = 1;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shootSpeed = 14f;
			item.useStyle = 5;
        }
		
		
	    public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "Aquamarine", 8);
            recipe.AddIngredient(ItemID.Glass, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}
