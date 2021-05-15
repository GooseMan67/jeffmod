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

namespace jeffmod.Items.Weapon
{
	public class Tizona_1 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("[c/900C3F:Tizona 1]");
			Tooltip.SetDefault("The Sword of legendary hero  ");
		}

		public override void SetDefaults() 
		{
			item.damage = 30;
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 7;
			item.useAnimation = 7;
			item.useStyle = 1;
			item.knockBack = 10;
			item.value = 10000;
			item.rare = 9;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Jeffite_Bar>(), 3);
			recipe.AddIngredient(ItemID.HellstoneBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}