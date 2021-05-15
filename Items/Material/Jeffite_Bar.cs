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
    public class Jeffite_Bar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Jeffite Bar");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.rare = ItemRarityID.Pink;
            item.value = Item.sellPrice(silver: 10);
            item.maxStack = 999;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoldBar, 1);
            recipe.AddIngredient(ItemID.CopperBar, 1);
            recipe.AddIngredient(ItemID.SilverBar, 1);
            recipe.AddIngredient(ItemID.IronBar, 1);
            recipe.AddIngredient(ItemID.DemoniteBar, 1);
            recipe.AddIngredient(ItemID.HellstoneBar, 1);
            recipe.AddIngredient(ItemID.MeteoriteBar, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}