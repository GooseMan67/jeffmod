using Terraria.ID;
using Terraria.ModLoader;

namespace jeffmod.Items
{
	public class Soul_Scythe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("jeffablade"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("a forgotten scythe from the year 2013 removed from existence by an anime ");
		}

		public override void SetDefaults() 
		{
			item.damage = 85;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 100000;
			item.rare = -11;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = 274;
			item.shootSpeed = 7.5f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Excalibur, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}