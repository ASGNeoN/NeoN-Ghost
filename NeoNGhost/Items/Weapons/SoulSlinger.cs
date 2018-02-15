using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;
 
namespace NeoNGhost.Items.Weapons
{
    [AutoloadEquip()]
    public class SoulSlinger: ModItem
{
    public byte mode=0;
    public static string[] compatibleAmmo=
    {
        "SpectreSoul",
		"FlamingSoul",
		"DrownedSoul",
		"PhoenixSoul"
    };

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soulslinger");
            Tooltip.SetDefault("A strange hybrid between a gun and a magic staff, right click to change ammo");
        }
        public override void SetDefaults()
    {
		item.rare=8;
        item.magic=true;
		item.value=42300;
        item.damage=70;
        item.useStyle=5;
        item.useTime=15;
        item.useAnimation=15;
        item.shoot=10;//Just a placeholder(does not need to be changed)
		item.autoReuse=true;
        UpdateModeStats();
    }

public override void HoldItem(Player player)
{
    if(Main.mouseRightRelease&&Main.mouseRight&&SwitchMode(player))
    {
        UpdateModeStats();
    }
}

        public void UpdateModeStats()
        {
            ModItem ammo=mod.GetItem(compatibleAmmo[mode]);
            item.useAmmo=ammo.item.type;
            item.UseSound=ammo.item.UseSound;
        }
		public bool SwitchMode(Player player)
{
    for(int i=1;i<compatibleAmmo.Length;i++)
    {
        if(player.HasItem(mod.ItemType(compatibleAmmo[(mode+i)%compatibleAmmo.Length])))
        {
            mode=(byte)((mode+i)%compatibleAmmo.Length);
            return true;
        }
    }
    return false;
}
	    public override void AddRecipes()
		{
           ModRecipe recipe = new ModRecipe(mod);
           recipe.AddIngredient(ItemID.SpaceGun);
           recipe.AddIngredient(ItemID.SpectreBar, 12);	 		   
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
            return false;
        }
    }
}