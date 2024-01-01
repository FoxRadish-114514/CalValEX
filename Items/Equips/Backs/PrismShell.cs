﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalValEX.Items.Equips.Backs
{
    [AutoloadEquip(EquipType.Back)]
    public class PrismShell : ModItem
    {
        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 14;
            Item.height = 34;
            Item.value = Item.sellPrice(0, 1, 0, 0);
            Item.rare = ItemRarityID.Green;
            Item.accessory = true;
            Item.vanity = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            if (!hideVisual)
            {
                player.GetModPlayer<CalValEXPlayer>().prismshell = true;
            }
        }
        public override void UpdateVanity(Player player)
        {
            player.GetModPlayer<CalValEXPlayer>().prismshell = true;
        }
    }
}