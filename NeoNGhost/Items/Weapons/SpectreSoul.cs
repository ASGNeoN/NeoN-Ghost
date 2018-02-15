using Terraria.ID;
using Terraria.ModLoader;

namespace NeoNGhost.Items.Weapons
{
	public class SpectreSoul : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spectre Soul");
            Tooltip.SetDefault("Seems that this soul can be shot by a special gun");
        }
        public override void SetDefaults()
		{

			item.damage = 20;
			item.magic = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = 1.5f;
			item.value = 10;
			item.rare = 8;
			item.shoot = 297;  //The projectile shoot when your weapon using this ammo                //The speed of the projectile
			item.ammo=item.type;             //The ammo class this ammo belongs to.
			item.shootSpeed = 2+4f;  
			item.UseSound=new Terraria.Audio.LegacySoundStyle(2,43);
		}
		
	    public override void AddRecipes()
		{
           ModRecipe recipe = new ModRecipe(mod);
           recipe.AddIngredient(ItemID.Ectoplasm); 		   
           recipe.AddTile(TileID.CrystalBall);
           recipe.SetResult(this, 200);
           recipe.AddRecipe();
		}
		
	}
}
