using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalValEX.Items.Pets
{

    [LegacyName("AncientChoker")]
    public class SkullCluster : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Skull Cluster");
            /* Tooltip
                .SetDefault("Two skulls pop out of the pile with glowing eyes\n" + "Summons a miniature necrotic flesh golem"); */
            Item.ResearchUnlockCount = 1;
        }

        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.ZephyrFish);
            Item.UseSound = SoundID.NPCHit41;
            Item.shoot = ModContent.ProjectileType<Projectiles.Pets.Pillager>();
            Item.value = Item.sellPrice(0, 2, 0, 0);
            Item.rare = ItemRarityID.Yellow;
            Item.buffType = ModContent.BuffType<Buffs.Pets.PillagerBuff>();
        }

        public override void UseStyle(Player player, Microsoft.Xna.Framework.Rectangle heldItemFrame)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(Item.buffType, 3600, true);
            }
        }
    }
}