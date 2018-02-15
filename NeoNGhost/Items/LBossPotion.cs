using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace NeoNGhost.Items
{
    public class LBossPotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lesser Boss Potion");
            Tooltip.SetDefault("Gives various buffs");
        }
        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item3;                //this is the sound that plays when you use the item
            item.useStyle = 2;                 //this is how the item is holded when used
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 30;                 //this is where you set the max stack of item
            item.consumable = true;           //this make that the item is consumable when used
            item.width = 20;
            item.height = 28;
            item.value = 100;                
            item.rare = 1;
            item.buffType = BuffID.Regeneration;    //this is where you put your Buff name
            item.buffTime = 18000;    //this is the buff duration        20000 = 6 min
            return;
        }
    	public override bool UseItem(Player player)
	    {
			player.AddBuff(BuffID.Swiftness, 18000, false);
			player.AddBuff(BuffID.Ironskin, 18000, false);
			player.AddBuff(BuffID.NightOwl, 18000, false);
			player.AddBuff(BuffID.Endurance, 18000, false);
			return base.UseItem(player);
	    }
		    public override void AddRecipes()
		{
           ModRecipe recipe = new ModRecipe(mod);
           recipe.AddIngredient(ItemID.RegenerationPotion);
           recipe.AddIngredient(ItemID.EndurancePotion);	
           recipe.AddIngredient(ItemID.SwiftnessPotion);		
           recipe.AddIngredient(ItemID.NightOwlPotion);			
           recipe.AddIngredient(ItemID.IronskinPotion);				   
           recipe.AddTile(TileID.Bottles);
           recipe.SetResult(this);
           recipe.AddRecipe();
		}
	}
}