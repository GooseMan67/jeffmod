using Terraria;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace jeffmod.Items.Armours
{
    [AutoloadEquip(EquipType.Head)]
    public class BigRatMask : ModItem
    {
        public override void SetDefaults()
        {
            item.Size = new Vector2(18);
            item.value = Item.sellPrice(silver: 26);
            item.rare = ItemRarityID.Blue;
            item.defense = 69;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarBar, 69);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ItemType<TyrantScaleChestplate>() && legs.type == ItemType<TyrantScaleGreaves>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.meleeDamage += 0.4f;
            player.moveSpeed += 2f;
        }
    }
}
