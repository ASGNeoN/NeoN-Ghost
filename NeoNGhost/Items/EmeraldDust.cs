using Terraria.ID;
using Terraria.ModLoader;

namespace NeoNGhost.Items
{
	public class EmeraldDust : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Emerald Dust");
            Tooltip.SetDefault("A sandy emerald dust, it needs to be purified");
        }
        Mod Thorium = ModLoader.GetMod("ThoriumMod");
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 500;
			item.rare = 1;
        }
        	public override void AddRecipes()
        	{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SandBlock);	
            recipe.AddIngredient(ItemID.Emerald);	
            recipe.AddTile(TileID.WorkBenches);	
            recipe.SetResult(this,2);
            recipe.AddRecipe();
        		if(Thorium != null)
               	{recipe = new ModRecipe(mod);
        		recipe.AddIngredient(this);	
             recipe.AddIngredient(ModLoader.GetMod("ThoriumMod").ItemType("ArcaneDust"));			
            recipe.AddTile(null, "Crystallizer");
            recipe.SetResult(ItemID.Emerald);
            recipe.AddRecipe();}
        		else
        		{recipe = new ModRecipe(mod);
             recipe.AddIngredient(this);	
             recipe.AddIngredient(mod, "StarPiece");		
              recipe.AddTile(null, "Crystallizer");
              recipe.SetResult(ItemID.Emerald);
              recipe.AddRecipe();}
          }
    }
}
