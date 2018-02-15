using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace NeoNGhost.Items
{
    public class DewHeartMP : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dew Heart");
            Tooltip.SetDefault("Calls upon the clouds of Terraria."
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


        string rainoff = "Mods.NeoNGhost.RainOff";
        string rainon = "Mods.NeoNGhost.RainOn";
        Color messageColor = Color.SkyBlue;
        public override bool UseItem(Player player)
        {
            if (Main.raining == true)
            {
                 if (Main.netMode == 2) // Server
                {
                 NetMessage.BroadcastChatMessage(NetworkText.FromKey(rainoff), messageColor);
                }
                else if (Main.netMode == 0) // Single Player
                {
                    Main.NewText(Language.GetTextValue(rainoff), messageColor);
                }
                Main.raining = false;
                Main.rainTime = 0;
                Main.maxRaining = 0.0f;
                return true;
            }
            else if (Main.raining == false && Main.slimeRain == false)
            {

                if (Main.netMode == 2) // Server
                {
                  NetMessage.BroadcastChatMessage(NetworkText.FromKey(rainon), messageColor);
                }
                else if (Main.netMode == 0) // Single Player
                {
                    Main.NewText(Language.GetTextValue(rainon), messageColor);
                }
                int maxValue1 = 86400;
                int maxValue2 = maxValue1 / 24;
                Main.rainTime = Main.rand.Next(maxValue2 * 8, maxValue1);
                if (Main.rand.Next(3) == 0)
                    Main.rainTime += Main.rand.Next(0, maxValue2);
                if (Main.rand.Next(4) == 0)
                    Main.rainTime += Main.rand.Next(0, maxValue2 * 2);
                if (Main.rand.Next(5) == 0)
                    Main.rainTime += Main.rand.Next(0, maxValue2 * 2);
                if (Main.rand.Next(6) == 0)
                    Main.rainTime += Main.rand.Next(0, maxValue2 * 3);
                if (Main.rand.Next(7) == 0)
                    Main.rainTime += Main.rand.Next(0, maxValue2 * 4);
                if (Main.rand.Next(8) == 0)
                    Main.rainTime += Main.rand.Next(0, maxValue2 * 5);
                float num = 1f;
                if (Main.rand.Next(2) == 0)
                    num += 0.05f;
                if (Main.rand.Next(3) == 0)
                    num += 0.1f;
                if (Main.rand.Next(4) == 0)
                    num += 0.15f;
                if (Main.rand.Next(5) == 0)
                    num += 0.2f;
                Main.rainTime = (int)((double)Main.rainTime * (double)num);
                RainStuff();
                Main.raining = true;
                return true;
            }
            return false;
        }
        public static void RainStuff()
        {
            if ((double)Main.cloudBGActive >= 1.0 || (double)Main.numClouds > 150.0)
            {
                if (Main.rand.Next(3) == 0)
                    Main.maxRaining = (float)Main.rand.Next(20, 90) * 0.01f;
                else
                    Main.maxRaining = (float)Main.rand.Next(40, 90) * 0.01f;
            }
            else if ((double)Main.numClouds > 100.0)
            {
                if (Main.rand.Next(3) == 0)
                    Main.maxRaining = (float)Main.rand.Next(10, 70) * 0.01f;
                else
                    Main.maxRaining = (float)Main.rand.Next(20, 60) * 0.01f;
            }
            else if (Main.rand.Next(3) == 0)
                Main.maxRaining = (float)Main.rand.Next(5, 40) * 0.01f;
            else
                Main.maxRaining = (float)Main.rand.Next(5, 30) * 0.01f;
        }

        public override void AddRecipes()
		{
           ModRecipe recipe = new ModRecipe(mod);
           recipe.AddIngredient(ItemID.Cloud, 30);	   
           recipe.AddIngredient(ItemID.SoulofFlight, 10);	
           recipe.AddTile(TileID.WorkBenches);		   
           recipe.SetResult(this);
           recipe.AddRecipe();
     recipe = new ModRecipe(mod);
    recipe.AddIngredient(this);
   recipe.SetResult(mod, "DewHeart");
      recipe.AddRecipe();
      recipe = new ModRecipe(mod);
       recipe.AddIngredient(mod, "DewHeart");
recipe.SetResult(this);
     recipe.AddRecipe();
        }

    }	
}