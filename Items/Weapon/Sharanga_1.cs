using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using jeffmod.Items.Material;
using jeffmod.Items.Weapon;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria;

namespace jeffmod.Items.Weapon
{
    public class Sharanga_1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("[c/900C3F:Sharanga 1]"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("A Legendary Bow");
        }

        public override void SetDefaults()
        {
            item.Size = new Vector2(12, 24);
            item.rare = ItemRarityID.Blue;
            item.value = Item.sellPrice(silver: 22);

            item.useTime = 5;
            item.useAnimation = 25;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.UseSound = SoundID.Item5;

            item.noMelee = true;
            item.ranged = true;
            item.damage = 7;
            item.autoReuse = true;

            item.useAmmo = AmmoID.Arrow;
            item.shoot = 1;
            item.shootSpeed = 7.5f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Jeffite_Bar>(),3);
            recipe.AddIngredient(ItemID.HellstoneBar, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
