using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace NeoNGhost.Items
{
    public class WisdomHeart : ModItem
    {
        string expertoff = "Mods.NeoNGhost.ExpertOff";
        string experton = "Mods.NeoNGhost.ExpertOn";
        Color messageColor = Color.Green;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wisdom Heart");
            Tooltip.SetDefault("Calls upon the true forces of Terraria.");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(8, 3));
        }
        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item6;                //this is the sound that plays when you use the item      
            item.useAnimation = 20;
            item.useTime = 20;
			item.useStyle = 5;
            item.shoot = 416;
            item.maxStack = 1;                 //this is where you set the max stack of item
            item.consumable = false;           //this make that the item is consumable when used
            item.noMelee = true;
            item.noUseGraphic = true;
            item.width = 20;
            item.height = 22;
            item.value = 0;
            item.shootSpeed = 5f;
            item.rare = 1;
            return;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
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
	     }
    }	
}