using Terraria.ID;
using Terraria.ModLoader;

namespace jeffmod.Items
{
	public class Merchant : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Merchant"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("For Timmy.");
		}

		public override void SetDefaults() 
		{
			item.damage = 21;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 1;
			item.value = 10;
			item.rare = -12;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SilverCoin, 50);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}