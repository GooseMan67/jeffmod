using Terraria.ID;
using Terraria.ModLoader;

namespace jeffmod.Items
{
	public class Spectre_Breaker : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("[c/1EC3DA:Spectre Breaker]");
			Tooltip.SetDefault("Screaming Echo From the dungeon");
		}

		public override void SetDefaults()
		{
			item.damage = 150;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 17;
			item.useAnimation = 17;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 9;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = 297;
			item.shootSpeed = 5.5f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Ectoplasm, 50);
			recipe.AddIngredient(ItemID.SpectreStaff, 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}