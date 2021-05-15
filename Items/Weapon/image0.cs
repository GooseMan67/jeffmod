using Terraria.ID;
using Terraria.ModLoader;

namespace jeffmod.Items.Weapon
{
	public class image0 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("[c/1EC3DA:Feet]");
			Tooltip.SetDefault("Screaming Echo From the dungeon");
		}

		public override void SetDefaults()
		{
			item.damage = 69;
			item.melee = true;
			item.width = 10;
			item.height = 10;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 9;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = 295;
			item.shootSpeed = 2.5f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 50);
			recipe.AddIngredient(ItemID.ShadowbeamStaff, 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}