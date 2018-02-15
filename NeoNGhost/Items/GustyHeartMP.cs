using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Events;
using Terraria.Localization;

namespace NeoNGhost.Items
{
    public class GustyHeartMP : ModItem
    {
        string sandoff = "Mods.NeoNGhost.SandOff";
        string sandon = "Mods.NeoNGhost.SandOn";
        Color messageColor = Color.Yellow;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gusty Heart");
            Tooltip.SetDefault("Calls upon the sandy gusts of Terraria."
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
            if (Sandstorm.Happening == true)
            {
                if (Main.netMode == 2) // Server
                {
                    NetMessage.BroadcastChatMessage(NetworkText.FromKey(sandoff), messageColor);
                }
                else if (Main.netMode == 0) // Single Player
                {
                    Main.NewText(Language.GetTextValue(sandoff), messageColor);
                }
                Sandstorm.Happening = false;
                Sandstorm.TimeLeft = 0;
                SandstormStuff();
                return true;
            }
            else if (Sandstorm.Happening == false)
            {
                if (Main.netMode == 2) // Server
                {
                    NetMessage.BroadcastChatMessage(NetworkText.FromKey(sandon), messageColor);
                }
                else if (Main.netMode == 0) // Single Player
                {
                    Main.NewText(Language.GetTextValue(sandon), messageColor);
                }
                Sandstorm.Happening = true;
                Sandstorm.TimeLeft = (int)(3600.0 * (8.0 + (double)Main.rand.NextFloat() * 16.0));
                SandstormStuff();
                return true;
            }
            return false;
        }
        public static void SandstormStuff()
        {
            Sandstorm.IntendedSeverity = !Sandstorm.Happening ? (Main.rand.Next(3) != 0 ? Main.rand.NextFloat() * 0.3f : 0.0f) : 0.4f + Main.rand.NextFloat();
            if (Main.netMode == 1)
                return;
            NetMessage.SendData(7, -1, -1, null, 0, 0.0f, 0.0f, 0.0f, 0, 0, 0);
        }

        public override void AddRecipes()
		{
           ModRecipe recipe = new ModRecipe(mod);
           recipe.AddIngredient(ItemID.SandBlock, 30);	   
           recipe.AddIngredient(ItemID.SoulofFlight, 10);	
           recipe.AddTile(TileID.WorkBenches);		   
           recipe.SetResult(this);
           recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(this);
            recipe.SetResult(mod, "GustyHeart");
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "GustyHeart");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }	
}