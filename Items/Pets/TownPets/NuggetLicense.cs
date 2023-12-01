﻿using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Humanizer;

namespace CalValEX.Items.Pets.TownPets {
    public class NuggetLicense : ModItem {
        public override void SetStaticDefaults() => Item.ResearchUnlockCount = 1;

        public override void SetDefaults() => Item.CloneDefaults(ItemID.LicenseDog);

        public static int PickANug (int pick) {
            switch (pick) {
                case 0:
                    if (!CalValEXWorld.nugget) {
                        CalValEXWorld.nugget = true;
                        return pick;
                    } else {
                        pick = Main.rand.Next(0, 6);
                        return PickANug(pick);
                    }
                case 1:
                    if (!CalValEXWorld.draco) {
                        CalValEXWorld.draco = true;
                        return pick;
                    } else {
                        pick = Main.rand.Next(0, 6);
                        return PickANug(pick);
                    }
                case 2:
                    if (!CalValEXWorld.folly) {
                        CalValEXWorld.folly = true;
                        return pick;
                    } else {
                        pick = Main.rand.Next(0, 6);
                        return PickANug(pick);
                    }
                case 3:
                    if (!CalValEXWorld.godnug) {
                        CalValEXWorld.godnug = true;
                        return pick;
                    } else {
                        pick = Main.rand.Next(0, 6);
                        return PickANug(pick);
                    }
                case 4:
                    if (!CalValEXWorld.mammoth) {
                        CalValEXWorld.mammoth = true;
                        return pick;
                    } else {
                        pick = Main.rand.Next(0, 6);
                        return PickANug(pick);
                    }
                case 5:
                    if (!CalValEXWorld.shadow) {
                        CalValEXWorld.shadow = true;
                        return pick;
                    } else {
                        pick = Main.rand.Next(0, 6);
                        return PickANug(pick);
                    }
                default:
                    return -1;
            }
        }

        public override bool ConsumeItem(Player player) {
            if (!CalValEXWorld.CanNugsSpawn())
                return false;

            return base.ConsumeItem(player);
        }

        public override bool? UseItem(Player player) {
            if (CalValEXWorld.CanNugsSpawn()) {
                int spawnwhichnug = Main.rand.Next(0, 6);
                PickANug(spawnwhichnug);
                if (Main.netMode == NetmodeID.SinglePlayer)
                    Main.NewText(Language.GetTextValue("Mods.CalValEX.NPCs.NuggetNugget.Canspawn"), 50, byte.MaxValue, 130);
                else
                    NetMessage.SendData(MessageID.SpawnBossUseLicenseStartEvent, -1, -1, null, player.whoAmI, -13f, 0.0f, 0.0f, 0, 0, 0);
                return true;
            } else {
                Main.NewText(Language.GetTextValue("Mods.CalValEX.NPCs.NuggetNugget.Nospace").FormatWith(Main.worldName), byte.MaxValue, 0, 0);
                return true;
            }
        }

    }
}