using Terraria.ID;
using Terraria.ModLoader;

namespace jeffmod.Items.Weapon
{
	public class Shadowbeam_Sword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("[c/1EC3DA:ShadowBeam Blade]");
			Tooltip.SetDefault("Screaming Echo From the dungeon");
		}

		public override void SetDefaults()
		{
			item.damage = 125;
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
			item.shoot = 294;
			item.shootSpeed = 2.5f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Ectoplasm, 50);
			recipe.AddIngredient(ItemID.ShadowbeamStaff, 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}