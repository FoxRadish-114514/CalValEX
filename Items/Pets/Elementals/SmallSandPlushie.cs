﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalValEX.Items.Pets.Elementals
{
    [LegacyName("SandPlush")]
    public class SmallSandPlushie : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Small Sand Plushie");
            // Tooltip.SetDefault("An elemental's favorite toy!\n" + "Summons a Rare Miniature Sand Elemental");
            Item.ResearchUnlockCount = 1;
        }

        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.ZephyrFish);
            Item.UseSound = SoundID.NPCHit5;
            Item.shoot = ModContent.ProjectileType<Projectiles.Pets.Elementals.RaresandMini>();
            Item.value = Item.sellPrice(0, 2, 0, 0);
            Item.rare = ItemRarityID.Pink;
            Item.buffType = ModContent.BuffType<Buffs.Pets.Elementals.RareSsandBuff>();
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