using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace jeffmod.Items.Material
{
    public class Soul_Of_Jeff : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soul Of Jeff");
            Tooltip.SetDefault("A Strange combination");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.rare = ItemRarityID.Red;
            item.value = Item.sellPrice(silver: 10);
            item.maxStack = 999;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SoulofFright, 1);
            recipe.AddIngredient(ItemID.SoulofMight, 1);
            recipe.AddIngredient(ItemID.SoulofSight, 1);
            recipe.AddIngredient(ItemID.SoulofFlight, 1);
            recipe.AddIngredient(ItemID.SoulofNight, 1);
            recipe.AddIngredient(ItemID.SoulofLight, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}