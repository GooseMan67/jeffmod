using Terraria.ID;
using Terraria.ModLoader;

namespace jeffmod.Items
{
	public class TyrantEdge: ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("[c/00FF21:Tyrant TerraBlade]");
			Tooltip.SetDefault("the blade of life");
		}

		public override void SetDefaults() 
		{
			item.damage = 69;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 13;
			item.useAnimation = 13;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 7;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = 20;
			item.shootSpeed = 3f;
		
		}
	}
}