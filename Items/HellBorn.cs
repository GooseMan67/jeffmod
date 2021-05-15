using Terraria.ID;
using Terraria.ModLoader;

namespace jeffmod.Items
{
	public class HellBorn : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("[c/FF0051:Hell Born]");
			Tooltip.SetDefault("the sword of an undying Tyrant");
		}

		public override void SetDefaults()
		{
			item.damage = 21000;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = -12;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = 684;
			item.shootSpeed = 7.5f;
		}

	}
}