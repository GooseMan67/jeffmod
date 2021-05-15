﻿using jeffmod.Items;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace jeffmod.Items.TreasureBags
{
	public class FredBag : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Treasure Bag");
			Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;
			item.consumable = true;
			item.width = 24;
			item.height = 24;
			item.rare = ItemRarityID.Cyan;
			item.expert = true;
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void OpenBossBag(Player player)
		{
			player.TryGettingDevArmor();
			if (Main.rand.NextBool(7))
			{
				player.QuickSpawnItem(ModContent.ItemType<jeffsword>());
			}
			player.QuickSpawnItem(ModContent.ItemType<HellBorn>());
		}

		public override int BossBagNPC => ModContent.NPCType<NPCs.FredOverlord>();
	}
}