using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace TechnobladePainting.Content.Items.Placeable.Furniture
{
	public class TechnobladePainting : ModItem
	{
		public override void SetStaticDefaults() {
			// DisplayName.SetDefault("Technoblade Painting");
			// Tooltip.SetDefault("'Technoblade never dies'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			// Vanilla has many useful methods like these, use them! This substitutes setting Item.createTile and Item.placeStyle aswell as setting a few values that are common across all placeable items
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.TechnobladePainting>());

			Item.width = 48;
			Item.height = 32;
			Item.maxStack = 99;
			Item.rare = ItemRarityID.Pink;
			Item.value = Item.buyPrice(0, 1);
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddIngredient(ItemID.Silk, 5);
			recipe.AddIngredient(ItemID.PinkDye, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}
