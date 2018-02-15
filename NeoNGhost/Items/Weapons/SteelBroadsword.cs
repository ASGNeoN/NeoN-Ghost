using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace NeoNGhost.Items.Weapons
{
	public class SteelBroadsword : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Steel Broadsword");
            Tooltip.SetDefault("Right click to.. 'End him Rightly'!");
        }
        public override void SetDefaults()
		{
			item.damage = 15;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 33;
			item.useAnimation = 33;
			item.useTurn = true;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 300;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
		public override void AddRecipes()
		{
           ModRecipe recipe = new ModRecipe(mod);
           recipe.AddIngredient(ItemID.IronBroadsword);
            recipe.needWater = true;
            recipe.AddTile(TileID.Furnaces);
           recipe.SetResult(this);
           recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LeadBroadsword);
            recipe.needWater = true;
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                item.useStyle = 1;
                item.useTime = 60;
                item.useAnimation = 60;
                item.damage = 5;
                item.shoot = mod.ProjectileType("Pommel");
            }
            else
            {
                item.useStyle = 1;
                item.useTime = 33;
                item.useAnimation = 33;
                item.damage = 15;
                item.shoot = 0;
                item.shootSpeed = 6f;
            }
            return base.CanUseItem(player);
        }


    }
}
