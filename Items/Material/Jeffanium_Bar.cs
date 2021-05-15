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
    public class Jeffanium_Bar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Jeffanium Bar");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.rare = ItemRarityID.Purple;
            item.value = Item.sellPrice(silver: 10);
            item.maxStack = 999;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CobaltBar, 1);
            recipe.AddIngredient(ItemID.MythrilBar, 1);
            recipe.AddIngredient(ItemID.AdamantiteBar, 1);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 1);
            recipe.AddIngredient(ItemID.HallowedBar, 1);
            recipe.AddIngredient(ItemID.ShroomiteBar, 1);
            recipe.AddIngredient(ItemID.SpectreBar, 1);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}