using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace NeoNGhost.Items
{
    public class BossPotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Boss Potion");
            Tooltip.SetDefault("Gives various strong buffs");
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
            item.rare = 3;
            item.buffType = BuffID.Regeneration;    //this is where you put your Buff name
            item.buffTime = 20000;    //this is the buff duration        20000 = 6 min
            return;
        }
    	public override bool UseItem(Player player)
	    {
			player.AddBuff(BuffID.Swiftness, 20000, false);
			player.AddBuff(BuffID.Ironskin, 20000, false);
			player.AddBuff(BuffID.NightOwl, 20000, false);
			player.AddBuff(BuffID.Endurance, 20000, false);
			player.AddBuff(BuffID.Wrath, 20000, false);			
			player.AddBuff(BuffID.Rage, 20000, false);		
			player.AddBuff(BuffID.Lifeforce, 20000, false);
			player.AddBuff(BuffID.Heartreach, 20000, false);
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
           recipe.AddIngredient(ItemID.WrathPotion);	
           recipe.AddIngredient(ItemID.RagePotion);		
           recipe.AddIngredient(ItemID.LifeforcePotion);	
           recipe.AddIngredient(ItemID.HeartreachPotion);			   
           recipe.AddTile(TileID.Bottles);		   
           recipe.SetResult(this);
           recipe.AddRecipe();


           	   recipe = new ModRecipe(mod);
                 recipe.AddIngredient(mod, "LBossPotion");
                 recipe.AddIngredient(ItemID.WrathPotion);	
                  recipe.AddIngredient(ItemID.RagePotion);		
                recipe.AddIngredient(ItemID.LifeforcePotion);	
                  recipe.AddIngredient(ItemID.HeartreachPotion);			   
                recipe.AddTile(TileID.Bottles);
                recipe.SetResult(this);
                recipe.AddRecipe();
        }
    }	
}