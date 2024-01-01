using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CalValEX.Items.Hooks
{
    public class ProfanedEnergyHook : ModItem {
        public override void SetStaticDefaults() => Item.ResearchUnlockCount = 1;

        public override void SetDefaults()
        {
            Item.rare = ItemRarityID.Purple;
            Item.CloneDefaults(ItemID.BatHook);
            Item.value = Item.sellPrice(1, 1, 0, 0);
            Item.shootSpeed = 16f;
            Item.shoot = ProjectileType<ProfanedHook>();
        }
    }
}