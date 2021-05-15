using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using jeffmod.Items.Material;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria;

namespace jeffmod.Items
{
	public class forgotenblade : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("[c/FF0051:Forgotten Blade]");
			Tooltip.SetDefault("A Sword Forged For a old tyrant ");
		}

		public override void SetDefaults() 
		{
			item.damage = 200;
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 10;
			item.value = 10000;
			item.rare = -12;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = 295;
			item.shootSpeed = 5.5f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Fred_Bar>(), 3);
			recipe.AddIngredient(ItemID.LunarBar, 5);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}