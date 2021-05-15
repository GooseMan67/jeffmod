using Terraria.ID;
using Terraria.ModLoader;

namespace jeffmod.Items
{
	public class TyrantJeffUltisword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("TyrantJeffUltisword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Its From UK  (Original sprite made by calamity mod)");
		}

		public override void SetDefaults() 
		{
			item.damage = 42069;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = 1;
			item.knockBack = 1;
			item.value = 10;
			item.rare = -11;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
			item.shoot = 228;
			item.shootSpeed = 7.5f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10000);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}