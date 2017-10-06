using Terraria.ID;
using Terraria.ModLoader;

namespace VoidAddons.Items.Placeable
{
	public class VoidWorkbench : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Craft your Voidy needs");
		}

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 14;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
			item.createTile = mod.TileType("VoidWorkbench");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WorkBench);
			recipe.AddIngredient(null, "VoidBlock", 10);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}