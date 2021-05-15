using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using jeffmod.Projectiles;

namespace jeffmod.Items.Accessories
{
    public class BingusHook : ModItem
    {
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.AmethystHook);
            item.shootSpeed = 18f;
            item.shoot = mod.ProjectileType("TutorialHook");
        }
    }
}