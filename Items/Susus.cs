using Terraria.ID;
using Terraria.ModLoader;

namespace jeffmod.Items
{
	public class Susus : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("SUSUSAMONGUS SUS"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("3am among us hapy meal real guy me hordor it. Normal mode exclusive");
		}

		public override void SetDefaults() 
		{
			item.damage = 1;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 2;
			item.useAnimation = 2;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = -12;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}