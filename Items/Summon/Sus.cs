using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace jeffmod.Items.Summon
{
    public class Sus : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("SUSpiscious looking face");
            Tooltip.SetDefault("Summon The Tyrant SUS");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 20;
            item.value = 100;
            item.rare = 11;
            item.useAnimation = 40;
            item.useTime = 45;
            item.consumable = true;

            item.useStyle = 4; // Holds up like a summon item.
        }

        public override bool CanUseItem(Player player)
        {
            // Main Bosses
            bool queenBee = NPC.downedQueenBee; // Downed Queen Bee

            bool bossOne = NPC.downedBoss1; // Downed EoC
            bool bossTwo = NPC.downedBoss2; // Downed EoW or BoC
            bool bossThree = NPC.downedBoss3; // Downed Skeletron

            bool isHardmode = Main.hardMode; // Downed WoF

            bool mechOne = NPC.downedMechBoss1; // Downed The Twins
            bool mechTwo = NPC.downedMechBoss2; // Downed The Destroyer
            bool mechThree = NPC.downedMechBoss3; // Downed Skeletron Prim

            bool plantera = NPC.downedPlantBoss; // Downed Plantera
            bool golem = NPC.downedGolemBoss; // Downed Golem;
            bool cultist = NPC.downedAncientCultist; // Downed Cultist
            bool moonLord = NPC.downedMoonlord; // Downed MoonLord

            // Does NPC Exist
            bool alreadySpawned = NPC.AnyNPCs(mod.NPCType("TheTyrant"));

            // return NPC.downedQueenBee && Main.hardMode && !NPC.AnyNPCs(mod.NPCType("TutorialBoss")); // NPC will spawn if No existing Tutorial Boss, Queen Bee is downed and it is hardmode 
            return !alreadySpawned;
        }

        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("TheTyrant")); // Spawn the boss within a range of the player. 
            Main.PlaySound(SoundID.Roar, player.position, 0);
            return true;
        }
                    public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Bone, 10);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}