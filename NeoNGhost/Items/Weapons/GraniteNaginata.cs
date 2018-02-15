using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;

namespace NeoNGhost.Items.Weapons
{
	public class GraniteNaginata : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Granite Naginata");
            Tooltip.SetDefault("Heavy to hold and intimidating!");
        }
        public override void SetDefaults()
		{
			item.damage = 46;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 22;
			item.useAnimation =26;
			item.useStyle = 5;
			item.knockBack = 6;
            item.channel = true;
            item.noUseGraphic = true;
			item.useTurn = false;﻿
            item.noMelee = true;
			item.value = 30000;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
			item.shoot = mod.ProjectileType("GraniteNaginata");
			item.shootSpeed = 3.7f;
		}
		public override void AddRecipes()
		{
           ModRecipe recipe = new ModRecipe(mod);
           recipe.AddIngredient(ItemID.GraniteBlock, 50);
           recipe.AddIngredient(ItemID.DarkShard, 2);	 	
           recipe.AddIngredient(ItemID.SoulofNight, 5);		
           recipe.AddIngredient(ItemID.SoulofFright, 5);			   
           recipe.AddTile(TileID.MythrilAnvil);
           recipe.SetResult(this);
           recipe.AddRecipe();
		}
		public override bool CanUseItem(Player player)
		{
			return player.ownedProjectileCounts[item.shoot] < 1; // This is to ensure the spear doesn't bug out when using autoReuse = true
		}
	}
}
