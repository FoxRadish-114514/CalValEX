using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalValEX.Items.Pets.Scuttlers
{
    [LegacyName("EmeraldStone")]
    public class EmeraldGeode : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Emerald Geode");
            /* Tooltip
                .SetDefault("May contain a scuttler"); */
            Item.ResearchUnlockCount = 1;
        }

        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.ZephyrFish);
            Item.UseSound = SoundID.NPCHit31;
            Item.shoot = ModContent.ProjectileType<Projectiles.Pets.Scuttlers.EmeraldPet>();
            Item.value = Item.sellPrice(0, 1, 0, 0);
            Item.rare = ItemRarityID.Blue;
            Item.buffType = ModContent.BuffType<Buffs.Pets.Scuttlers.EmeraldBuff>();
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