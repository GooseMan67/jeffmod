using Terraria.ID;
using Terraria.ModLoader;

namespace jeffmod.Items.Weapon
{
	public class RaiderBlade: ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("RaiderSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("GameRaider more like JeffRaider");
		}

		public override void SetDefaults() 
		{
			item.damage = 10000000;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 2;
			item.useAnimation = 2;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 11;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = 297;
			item.shootSpeed = 10.5f;

		}

		
		
	}
}