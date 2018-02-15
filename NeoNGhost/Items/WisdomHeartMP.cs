using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace NeoNGhost.Items
{
    public class WisdomHeartMP : ModItem
    {
        string expertoff = "Mods.NeoNGhost.ExpertOff";
        string experton = "Mods.NeoNGhost.ExpertOn";
        Color messageColor = Color.Green;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wisdom Heart");
            Tooltip.SetDefault("Calls upon the true forces of Terraria."
                                + "\n-Less fancy but works in Multiplayer-");
        }
        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item6;                //this is the sound that plays when you use the item      
            item.useAnimation = 20;
            item.useTime = 20;
			item.useStyle = 5;
            item.maxStack = 1;                 //this is where you set the max stack of item
            item.consumable = false;           //this make that the item is consumable when used
            item.width = 20;
            item.height = 22;
            item.value = 0;
            item.rare = 1;
            return;
        }

        public override bool UseItem(Player player)
        {
			if (Main.expertMode)
			{
                if (Main.netMode == 2) // Server
                {
                    NetMessage.BroadcastChatMessage(NetworkText.FromKey(expertoff), messageColor);
                }
                else if (Main.netMode == 0) // Single Player
                {
                    Main.NewText(Language.GetTextValue(expertoff), messageColor);
                }

            }
		    else
			{
                if (Main.netMode == 2) // Server
                {
                    NetMessage.BroadcastChatMessage(NetworkText.FromKey(experton), messageColor);
                }
                else if (Main.netMode == 0) // Single Player
                {
                    Main.NewText(Language.GetTextValue(experton), messageColor);
                }

            }
		
            Main.expertMode = !Main.expertMode;
            return true;
        }

        public override void AddRecipes()
		{
           ModRecipe recipe = new ModRecipe(mod);
           recipe.AddIngredient(ItemID.SoulofNight, 5);	   
           recipe.AddIngredient(ItemID.SoulofLight, 5);	
           recipe.AddIngredient(ItemID.Ichor, 5);	
           recipe.AddIngredient(ItemID.CrystalShard, 5);	
           recipe.AddTile(TileID.WorkBenches);		   
           recipe.SetResult(this);
           recipe.AddRecipe();
		   
           recipe = new ModRecipe(mod);
           recipe.AddIngredient(ItemID.SoulofNight, 5);	   
           recipe.AddIngredient(ItemID.SoulofLight, 5);	
           recipe.AddIngredient(ItemID.CursedFlame, 5);	
           recipe.AddIngredient(ItemID.CrystalShard, 5);	
           recipe.AddTile(TileID.WorkBenches);		   
           recipe.SetResult(this);
           recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(this);
            recipe.SetResult(mod, "WisdomHeart");
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "WisdomHeart");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}