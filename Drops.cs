using CalValEX.Items;
using CalValEX.Items.Critters;
using CalValEX.Items.Equips;
using CalValEX.Items.Hooks;
using CalValEX.Items.Mounts;
using CalValEX.Items.Pets;
using CalValEX.Items.Tiles;
using CalValEX.Items.Tiles.Balloons;
using CalValEX.Items.Tiles.FurnitureSets.Necrotic;
using CalValEX.Items.Tiles.Paintings;
using CalValEX.Items.Tiles.Plants;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalValEX
{
    public class Drops : GlobalNPC
    {
        public readonly float rareEnemyChance = 0.1f; //10%
        public readonly float normalEnemyChance = 0.05f; //5%
        public readonly float extraDefiledChance = 0.05f; //5%
        public readonly float minibossChance = 0.1f; //10%
        public readonly float bossPetChance = 0.2f; //20%
        public readonly float bossHookChance = 0.1f; //10%
        public readonly float RIVChance = 0.075f; //7.5%
        
        public override bool InstancePerEntity => true;

        public readonly float vanityMinChance = 0.05f; //5%
        public readonly float vanityNormalChance = 0.1f; //10%
        public readonly float vanityMaxChance = 0.15f; //15%

        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            Mod clamMod = ModLoader.GetMod("CalamityMod"); //this is to get calamity mod, you have to add 'weakReferences = CalamityMod@1.4.4.4' (without the '') in your build.txt for this to work
            if (clamMod != null)
            {
                if (type == clamMod.NPCType("SEAHOE"))
                {
                    if ((bool)clamMod.Call("GetInZone", Main.player[Main.myPlayer], "sunkensea"))
                    {
                        if ((bool)clamMod.Call("GetBossDowned", "giantclam"))
                        {
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<SSCoral>());
                            shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 20, 0);
                            ++nextSlot;
                        }
                        {
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<Anemone>());
                            shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 20, 0);
                            ++nextSlot;
                        }
                        {
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<BrainCoral>());
                            shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 20, 0);
                            ++nextSlot;
                        }
                        {
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<TableCoral>());
                            shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 20, 0);
                            ++nextSlot;
                        }
                        {
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<FanCoral>());
                            shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 20, 0);
                            ++nextSlot;
                        }
                        if (Main.hardMode == true)
                        {
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<VVanities>());
                            shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 3, 0, 0);
                            ++nextSlot;
                        }
                        if ((bool)clamMod.Call("GetBossDowned", "acidrainscourge"))
                        {
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<BelchingCoral>());
                            shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 30, 0);
                            ++nextSlot;
                        }
                        if ((bool)clamMod.Call("GetBossDowned", "providence"))
                        {
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<BlazingConflict>());
                            shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 50, 0, 0);
                            ++nextSlot;
                        }
                        if ((bool)clamMod.Call("GetBossDowned", "oldduke"))
                        {
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<BloodwormScarf>());
                            shop.item[nextSlot].shopCustomPrice = Item.buyPrice(1, 50, 0, 0);
                            ++nextSlot;
                        }
                        if ((bool)clamMod.Call("GetBossDowned", "devourerofgods"))
                        {
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<CosmicTerror>());
                            shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 50, 0, 0);
                            ++nextSlot;
                        }
                        if ((bool)clamMod.Call("GetBossDowned", "buffedeclipse"))
                        {
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<TheYhar>());
                            shop.item[nextSlot].shopCustomPrice = Item.buyPrice(1, 80, 0, 0);
                            ++nextSlot;
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<CalamityFriends>());
                            shop.item[nextSlot].shopCustomPrice = Item.buyPrice(1, 0, 0, 0);
                            ++nextSlot;
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<WilliamPainting>());
                            shop.item[nextSlot].shopCustomPrice = Item.buyPrice(1, 0, 0, 0);
                            ++nextSlot;
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<CalamiteaTime>());
                            shop.item[nextSlot].shopCustomPrice = Item.buyPrice(1, 0, 0, 0);
                            ++nextSlot;
                        }
                        if ((bool)clamMod.Call("GetBossDowned", "supremecalamitas"))
                        {
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<Clam>());
                            shop.item[nextSlot].shopCustomPrice = Item.buyPrice(2, 0, 0, 0);
                            ++nextSlot;
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<Yharlamitas>());
                            shop.item[nextSlot].shopCustomPrice = Item.buyPrice(42, 0, 0, 0);
                            ++nextSlot;
                        }
                        if ((bool)clamMod.Call("GetBossDowned", "acidrain"))
                        {
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<SulphurColumn>());
                            shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 5, 0);
                            ++nextSlot;
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<SulphurGeyser>());
                            shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 5, 0);
                            ++nextSlot;
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<Ribrod>());
                            shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 2, 0, 0);
                            ++nextSlot;
                        }
                    }
                    if (!(bool)clamMod.Call("GetInZone", Main.player[Main.myPlayer], "sunkensea"))
                    {
                        if ((bool)clamMod.Call("GetBossDowned", "giantclam"))
                        {
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<SSCoral>());
                            shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 25, 0);
                            ++nextSlot;
                        }
                        {
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<Anemone>());
                            shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 25, 0);
                            ++nextSlot;
                        }
                        {
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<BrainCoral>());
                            shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 25, 0);
                            ++nextSlot;
                        }
                        {
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<TableCoral>());
                            shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 25, 0);
                            ++nextSlot;
                        }
                        {
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<FanCoral>());
                            shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 25, 0);
                            ++nextSlot;
                        }
                        if (Main.hardMode == true)
                        {
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<VVanities>());
                            shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 5, 0, 0);
                            ++nextSlot;
                        }
                        if ((bool)clamMod.Call("GetBossDowned", "acidrainscourge"))
                        {
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<BelchingCoral>());
                            shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 35, 0);
                            ++nextSlot;
                        }
                        if ((bool)clamMod.Call("GetBossDowned", "providence"))
                        {
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<BlazingConflict>());
                            shop.item[nextSlot].shopCustomPrice = Item.buyPrice(5, 0, 0, 0);
                            ++nextSlot;
                        }
                        if ((bool)clamMod.Call("GetBossDowned", "oldduke"))
                        {
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<BloodwormScarf>());
                            shop.item[nextSlot].shopCustomPrice = Item.buyPrice(15, 0, 0, 0);
                            ++nextSlot;
                        }
                        if ((bool)clamMod.Call("GetBossDowned", "buffedeclipse"))
                        {
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<TheYhar>());
                            shop.item[nextSlot].shopCustomPrice = Item.buyPrice(18, 0, 0, 0);
                            ++nextSlot;
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<CalamityFriends>());
                            shop.item[nextSlot].shopCustomPrice = Item.buyPrice(10, 0, 0, 0);
                            ++nextSlot;
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<WilliamPainting>());
                            shop.item[nextSlot].shopCustomPrice = Item.buyPrice(10, 0, 0, 0);
                            ++nextSlot;
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<CalamiteaTime>());
                            shop.item[nextSlot].shopCustomPrice = Item.buyPrice(10, 0, 0, 0);
                            ++nextSlot;
                        }
                        if ((bool)clamMod.Call("GetBossDowned", "supremecalamitas"))
                        {
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<Clam>());
                            shop.item[nextSlot].shopCustomPrice = Item.buyPrice(20, 0, 0, 0);
                            ++nextSlot;
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<Yharlamitas>());
                            shop.item[nextSlot].shopCustomPrice = Item.buyPrice(420, 0, 0, 0);
                            ++nextSlot;
                        }
                        if ((bool)clamMod.Call("GetBossDowned", "acidrain"))
                        {
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<SulphurColumn>());
                            shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 5, 0);
                            ++nextSlot;
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<SulphurGeyser>());
                            shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 5, 0);
                            ++nextSlot;
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<Ribrod>());
                            shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 1, 0, 0);
                            ++nextSlot;
                        }
                    }
                }
                if (type == clamMod.NPCType("DILF"))
                {
                    if ((bool)clamMod.Call("GetBossDowned", "signus"))
                    {
                        shop.item[nextSlot].SetDefaults(ModContent.ItemType<Signut>());
                        shop.item[nextSlot].shopCustomPrice = Item.buyPrice(15, 0, 0, 0);
                        ++nextSlot;
                    }
                }
                if (type == clamMod.NPCType("THIEF"))
                {
                    if ((bool)clamMod.Call("GetBossDowned", "signus"))
                    {
                        shop.item[nextSlot].SetDefaults(ModContent.ItemType<Signut>());
                        shop.item[nextSlot].shopCustomPrice = Item.buyPrice(15, 0, 0, 0);
                        ++nextSlot;
                        shop.item[nextSlot].SetDefaults(ModContent.ItemType<AstrachnidTentacles>());
                        shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 5, 0, 0);
                        ++nextSlot;
                        shop.item[nextSlot].SetDefaults(ModContent.ItemType<AstrachnidThorax>());
                        shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 5, 0, 0);
                        ++nextSlot;
                        shop.item[nextSlot].SetDefaults(ModContent.ItemType<AstrachnidCranium>());
                        shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 5, 0, 0);
                        ++nextSlot;
                    }
                }
                if (type == NPCID.Clothier)
                {
                    int bandit = NPC.FindFirstNPC(clamMod.NPCType("THIEF"));
                    int archmage = NPC.FindFirstNPC(clamMod.NPCType("DILF"));
                    if (bandit != -1)
                    {
                        shop.item[nextSlot].SetDefaults(ModContent.ItemType<BanditHat>());
                        shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 3, 0, 0);
                        ++nextSlot;
                    }
                    if (archmage != -1)
                    {
                        shop.item[nextSlot].SetDefaults(ModContent.ItemType<Permascarf>());
                        shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 3, 0, 0);
                        ++nextSlot;
                    }
                    if ((bool)clamMod.Call("GetBossDowned", "astrumaureus"))
                        {
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<AureicFedora>());
                            shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 20, 0, 0);
                            ++nextSlot;
                        }
                }
                if (type == NPCID.Truffle)
                {
                    shop.item[nextSlot].SetDefaults(ModContent.ItemType<SwearshroomItem>());
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 2, 0);
                    ++nextSlot;
                }
                if (type == NPCID.PartyGirl)
                {
                    if (Main.LocalPlayer.HasItem(ModContent.ItemType<Mirballoon>()) || Main.LocalPlayer.HasItem(ModContent.ItemType<BoB2>()))
                    {
                        shop.item[nextSlot].SetDefaults(ModContent.ItemType<TiedMirageBalloon>());
                        shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 5, 0);
                        ++nextSlot;
                    }
                    if (Main.LocalPlayer.HasItem(ModContent.ItemType<BoxBalloon>()) || Main.LocalPlayer.HasItem(ModContent.ItemType<BoB2>()))
                    {
                        shop.item[nextSlot].SetDefaults(ModContent.ItemType<TiedBoxBalloon>());
                        shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 5, 0);
                        ++nextSlot;
                    }
                    if (Main.LocalPlayer.HasItem(ModContent.ItemType<ChaosBalloon>()) || Main.LocalPlayer.HasItem(ModContent.ItemType<BoB2>()))
                    {
                        shop.item[nextSlot].SetDefaults(ModContent.ItemType<TiedChaosBalloon>());
                        shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 5, 0);
                        ++nextSlot;
                    }
                    if (Main.LocalPlayer.HasItem(ModContent.ItemType<BoB2>()))
                    {
                        shop.item[nextSlot].SetDefaults(ModContent.ItemType<TiedBoB2>());
                        shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 5, 0);
                        ++nextSlot;
                    }
                }
            }
        }

        public override void NPCLoot(NPC npc)
        {
            Mod calamityMod = ModLoader.GetMod("CalamityMod");

            //5%/10% (non-defiled/defiled)
            float normalChance = normalEnemyChance + ((bool)calamityMod.Call("DifficultyActive", "defiled") ? extraDefiledChance : 0);
            //10%/15% (non-defiled/defiled)
            float rareChance = rareEnemyChance + ((bool)calamityMod.Call("DifficultyActive", "defiled") ? extraDefiledChance : 0);
            //1%/5% (non-defiled/defiled)
            float mountChance = 0.01f + ((bool)calamityMod.Call("DifficultyActive", "defiled") ? 0.04f : 0);

            if (npc.type == calamityMod.NPCType("DILF"))
            {
                DropItem(npc, ModContent.ItemType<Permascarf>()); //garanteed
            }
            if (npc.type == calamityMod.NPCType("THIEF"))
            {
                DropItem(npc, ModContent.ItemType<BanditHat>()); //garanteed
            }
            // Swearshrooms
            if (npc.type == calamityMod.NPCType("CrabShroom"))
            {
                if (!NPC.AnyNPCs(calamityMod.NPCType("CrabulonIdle")))
                {
                    if (Main.LocalPlayer.HasItem(calamityMod.ItemType("KnowledgeCrabulon")))
                    {
                        NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<Swearshroom>());
                    }
                }
            }
            //Prehm
            if (npc.type == calamityMod.NPCType("AngryDog"))
            {
                ChanceDropItem(npc, ModContent.ItemType<TundraBall>(), rareChance);
            }
            if (npc.type == calamityMod.NPCType("BoxJellyfish"))
            {
                ChanceDropItem(npc, ModContent.ItemType<BoxBalloon>(), rareChance);
            }
            if (npc.type == calamityMod.NPCType("Catfish"))
            {
                ChanceDropItem(npc, ModContent.ItemType<DiscardedCollar>(), normalChance);
            }
            if (npc.type == calamityMod.NPCType("Scryllar"))
            {
                ChanceDropItem(npc, ModContent.ItemType<ScryllianWings>(), normalChance);
            }
            if (npc.type == calamityMod.NPCType("ScryllarRage"))
            {
                ChanceDropItem(npc, ModContent.ItemType<ScryllianWings>(), normalChance);
            }
            if (npc.type == calamityMod.NPCType("DespairStone"))
            {
                ChanceDropItem(npc, ModContent.ItemType<Drock>(), normalChance);
            }
            if (npc.type == calamityMod.NPCType("WulfrumRover"))
            {
                ConditionalChanceDropItem(npc, ModContent.ItemType<WulfrumKeys>(), Main.expertMode, mountChance);
            }
            if (npc.type == calamityMod.NPCType("CosmicElemental"))
            {
                ChanceDropItem(npc, ModContent.ItemType<CosmicCone>(), normalChance);
            }
            if (npc.type == calamityMod.NPCType("Sunskater"))
            {
                ChanceDropItem(npc, ModContent.ItemType<SkeetCrest>(), normalChance);
            }
            if (npc.type == calamityMod.NPCType("ShockstormShuttle"))
            {
                ChanceDropItem(npc, ModContent.ItemType<ShuttleBalloon>(), rareChance);
            }
            if (npc.type == calamityMod.NPCType("AeroSlime"))
            {
                ConditionalChanceDropItem(npc, ModContent.ItemType<AeroWings>(), Main.expertMode, normalChance);
            }
            if (npc.type == calamityMod.NPCType("SeaFloaty"))
            {
                ConditionalChanceDropItem(npc, ModContent.ItemType<FloatyCarpetItem>(), Main.expertMode, normalChance);
            }
            if (npc.type == calamityMod.NPCType("SuperDummyNPC"))
            {
                ConditionalDropItem(npc, ModContent.ItemType<DummyMask>(), Main.LocalPlayer.HeldItem.type != calamityMod.ItemType("SuperDummy"));
            }
            //Crawlers
            if (npc.type == calamityMod.NPCType("CrawlerAmethyst"))
            {
                ChanceDropItem(npc, ModContent.ItemType<AmethystStone>(), rareChance);
            }
            if (npc.type == calamityMod.NPCType("CrawlerTopaz"))
            {
                ChanceDropItem(npc, ModContent.ItemType<TopazStone>(), rareChance);
            }
            if (npc.type == calamityMod.NPCType("CrawlerSapphire"))
            {
                ChanceDropItem(npc, ModContent.ItemType<SapphireStone>(), rareChance);
            }
            if (npc.type == calamityMod.NPCType("CrawlerEmerald"))
            {
                ChanceDropItem(npc, ModContent.ItemType<EmeraldStone>(), rareChance);
            }
            if (npc.type == calamityMod.NPCType("CrawlerRuby"))
            {
                ChanceDropItem(npc, ModContent.ItemType<RubyStone>(), rareChance);
            }
            if (npc.type == calamityMod.NPCType("CrawlerDiamond"))
            {
                ChanceDropItem(npc, ModContent.ItemType<DiamondStone>(), rareChance);
            }
            if (npc.type == calamityMod.NPCType("CrawlerCrystal"))
            {
                ChanceDropItem(npc, ModContent.ItemType<CrystalStone>(), rareChance);
            }
            if (npc.type == calamityMod.NPCType("CrawlerAmber"))
            {
                ChanceDropItem(npc, ModContent.ItemType<AmberStone>(), rareChance);
            }
            //end of crawler drops and prehm
            //Acid rain set tier 2
            if (npc.type == calamityMod.NPCType("SulfurousSkater"))
            {
                ChanceDropItem(npc, ModContent.ItemType<SkaterEgg>(), normalChance);
            }
            if (npc.type == calamityMod.NPCType("Orthocera"))
            {
                ChanceDropItem(npc, ModContent.ItemType<Help>(), normalChance);
            }
            if (npc.type == calamityMod.NPCType("FlakCrab"))
            {
                ChanceDropItem(npc, ModContent.ItemType<FlakHeadCrab>(), normalChance);
            }
            if (npc.type == calamityMod.NPCType("Trilobite"))
            {
                ChanceDropItem(npc, ModContent.ItemType<TrilobiteShield>(), normalChance);
            }
            if (npc.type == calamityMod.NPCType("GammaSlime"))
            {
                ChanceDropItem(npc, ModContent.ItemType<GammaHelmet>(), vanityMinChance);
                ChanceDropItem(npc, ModContent.ItemType<NuclearFumes>(), 0.3f); //30%
            }
            //Astral tree drops all
            if (npc.type == calamityMod.NPCType("AstralProbe"))
            {
                ChanceDropItem(npc, Main.rand.NextBool() ? ModContent.ItemType<AstralOldPurple>() : ModContent.ItemType<AstralOldYellow>(), 0.001f); //0.1% for either
            }
            if (npc.type == calamityMod.NPCType("SmallSightseer"))
            {
                ChanceDropItem(npc, Main.rand.NextBool() ? ModContent.ItemType<AstralOldPurple>() : ModContent.ItemType<AstralOldYellow>(), 0.001f); //0.1% for either
            }
            if (npc.type == calamityMod.NPCType("BigSightseer"))
            {
                ChanceDropItem(npc, Main.rand.NextBool() ? ModContent.ItemType<AstralOldPurple>() : ModContent.ItemType<AstralOldYellow>(), 0.001f); //0.1% for either
            }
            //Astral tree drops surface
            //These chances are not consistent at all. This is stupid. - Kawaggy
            if (npc.type == calamityMod.NPCType("Aries"))
            {
                ChanceDropItem(npc, ModContent.ItemType<AstralOldPurple>(), 0.001f); //0.1%
            }
            if (npc.type == calamityMod.NPCType("AstralSlime"))
            {
                ChanceDropItem(npc, ModContent.ItemType<AstralOldPurple>(), 0.01f); //1%
            }
            if (npc.type == calamityMod.NPCType("Atlas"))
            {
                ChanceDropItem(npc, ModContent.ItemType<AstralOldPurple>(), 0.01f); //1%
            }
            if (npc.type == calamityMod.NPCType("Nova"))
            {
                ChanceDropItem(npc, ModContent.ItemType<AstralOldPurple>(), 0.001f); //0.1%
            }
            if (npc.type == calamityMod.NPCType("Mantis"))
            {
                ChanceDropItem(npc, ModContent.ItemType<AstralOldPurple>(), 0.001f); //0.1%
            }
            if (npc.type == calamityMod.NPCType("FusionFeeder"))
            {
                ChanceDropItem(npc, ModContent.ItemType<AstralOldPurple>(), 0.002f); //0.2%
            }
            if (npc.type == calamityMod.NPCType("Hadarian"))
            {
                ChanceDropItem(npc, ModContent.ItemType<AstralOldPurple>(), 0.002f); //0.2%
            }
            //Astral tree drops underground
            if (npc.type == calamityMod.NPCType("Hive"))
            {
                ChanceDropItem(npc, ModContent.ItemType<AstralOldYellow>(), 0.002f); //0.2%
            }
            if (npc.type == calamityMod.NPCType("Astralachnea"))
            {
                ChanceDropItem(npc, ModContent.ItemType<AstralOldYellow>(), 0.002f); //0.2%
            }
            if (npc.type == calamityMod.NPCType("StellarCulex"))
            {
                ChanceDropItem(npc, ModContent.ItemType<AstralOldYellow>(), 0.001f); //0.1%
            }
            if (npc.type == calamityMod.NPCType("Hiveling"))
            {
                ChanceDropItem(npc, ModContent.ItemType<AstralOldYellow>(), 0.0001f); //0.01%
            }
            //Hardmode drops
            if (npc.type == calamityMod.NPCType("PerennialSlime"))
            {
                ChanceDropItem(npc, ModContent.ItemType<PerennialFlower>(), vanityNormalChance);
                ChanceDropItem(npc, ModContent.ItemType<PerennialDress>(), vanityNormalChance);
                ChanceDropItem(npc, ModContent.ItemType<PerennialFlower>(), RIVChance);
            }
            if (npc.type == calamityMod.NPCType("Bohldohr"))
            {
                ChanceDropItem(npc, ModContent.ItemType<BoldEgg>(), normalChance);
            }
            if (npc.type == calamityMod.NPCType("BelchingCoral"))
            {
                ChanceDropItem(npc, ModContent.ItemType<CoralMask>(), normalChance);
            }
            if (npc.type == calamityMod.NPCType("IceClasper"))
            {
                ChanceDropItem(npc, ModContent.ItemType<AntarcticEssence>(), normalChance);
            }
            if (npc.type == calamityMod.NPCType("Cryon"))
            {
                ChanceDropItem(npc, ModContent.ItemType<Cryocap>(), vanityNormalChance);
                ChanceDropItem(npc, ModContent.ItemType<Cryocoat>(), vanityNormalChance);
            }
            if (npc.type == calamityMod.NPCType("SmallSightseer"))
            {
                ConditionalChanceDropItem(npc, ModContent.ItemType<Binoculars>(), (bool)calamityMod.Call("GetBossDowned", "astrumaureus"), 0.05f); //5%
            }
            if (npc.type == calamityMod.NPCType("BigSightseer"))
            {
                ConditionalChanceDropItem(npc, ModContent.ItemType<Binoculars>(), (bool)calamityMod.Call("GetBossDowned", "astrumaureus"), 0.1f); //10%
            }
            if (npc.type == calamityMod.NPCType("CultistAssassin"))
            {
                ChanceDropItem(npc, ModContent.ItemType<CultistRobe>(), vanityMaxChance);
                ChanceDropItem(npc, ModContent.ItemType<CultistHood>(), vanityMaxChance);
                ChanceDropItem(npc, ModContent.ItemType<CultistLegs>(), vanityMaxChance);
            }
            if (npc.type == calamityMod.NPCType("HeatSpirit"))
            {
                ChanceDropItem(npc, ModContent.ItemType<ChaosEssence>(), normalChance);
            }
            if (npc.type == calamityMod.NPCType("OverloadedSoldier"))
            {
                ChanceDropItem(npc, ModContent.ItemType<UnloadedHelm>(), vanityMaxChance);
                ChanceDropItem(npc, ModContent.ItemType<HauntedPebble>(), normalChance);
            }
            if (npc.type == calamityMod.NPCType("PhantomDebris"))
            {
                ChanceDropItem(npc, ModContent.ItemType<HauntedPebble>(), normalChance);
            }
            if (npc.type == calamityMod.NPCType("DevilFishAlt"))
            {
                ChanceDropItem(npc, ModContent.ItemType<DevilfishMask1>(), vanityNormalChance);
            }
            if (npc.type == calamityMod.NPCType("DevilFish"))
            {
                ChanceDropItem(npc, ModContent.ItemType<DevilfishMask2>(), vanityNormalChance);
            }
            if (npc.type == calamityMod.NPCType("MirageJelly"))
            {
                ChanceDropItem(npc, ModContent.ItemType<Mirballoon>(), vanityNormalChance);
                ConditionalChanceDropItem(npc, ModContent.ItemType<OldMirage>(), NPC.downedGolemBoss, 0.01f); //1%
            }
            if (npc.type == calamityMod.NPCType("Hadarian"))
            {
                ConditionalChanceDropItem(npc, ModContent.ItemType<HadarianTail>(), (bool)calamityMod.Call("GetBossDowned", "astrumaureus"), 0.05f); //5%
            }
            if (npc.type == calamityMod.NPCType("Eidolist"))
            {
                ChanceDropItem(npc, ModContent.ItemType<EidoMask>(), vanityNormalChance);
                ChanceDropItem(npc, ModContent.ItemType<Eidcape>(), vanityNormalChance);
            }
            //Profaned enemies
            if (npc.type == calamityMod.NPCType("ProfanedEnergyBody") && Main.expertMode)
            {
                ConditionalChanceDropItem(npc, ModContent.ItemType<ProfanedEnergyHook>(), Main.expertMode, bossHookChance);
                ConditionalChanceDropItem(npc, ModContent.ItemType<ProfanedBalloon>(), Main.expertMode, vanityNormalChance);
                ConditionalChanceDropItem(npc, ModContent.ItemType<ChewyToy>(), (bool)calamityMod.Call("DifficultyActive", "revengeance"), 0.01f); //1%
            }
            if (npc.type == calamityMod.NPCType("ScornEater"))
            {
                ChanceDropItem(npc, ModContent.ItemType<ScornEaterMask>(), vanityNormalChance);
                ConditionalChanceDropItem(npc, ModContent.ItemType<ChewyToy>(), (bool)calamityMod.Call("DifficultyActive", "revengeance"), 0.01f); //1%
            }
            if (npc.type == calamityMod.NPCType("ImpiousImmolator"))
            {
                ChanceDropItem(npc, ModContent.ItemType<HolyTorch>(), 0.1f); //10%
                ChanceDropItem(npc, ModContent.ItemType<ProfanedBalloon>(), vanityNormalChance);
                ConditionalChanceDropItem(npc, ModContent.ItemType<ChewyToy>(), (bool)calamityMod.Call("DifficultyActive", "revengeance"), 0.01f); //1%
            }
            //Post-ml misc
            //if (npc.type == mod.NPCType("ShockstormShuttle"))
            //{
            //if (Main.rand.NextFloat() < 0.075f && NPC.downedMoonlord)

            // {
            //Item.NewItem(npc.getRect(),
            //     ModContent.ItemType<ExodiumMoon>());
            //}

            //else if (((bool) mod.Call("DifficultyActive", "defiled")) && Main.rand.NextFloat() < 0.2f && NPC.downedMoonlord)
            //{
            // Item.NewItem(npc.getRect(),
            //  ModContent.ItemType<ExodiumMoon>());
            //}
            //  }
            if (npc.type == calamityMod.NPCType("ChaoticPuffer"))
            {
                ChanceDropItem(npc, ModContent.ItemType<ChaosBalloon>(), vanityNormalChance);
            }
            //Minibosses
            if (npc.type == calamityMod.NPCType("NuclearTerror"))
            {
                DropItem(npc, ModContent.ItemType<NuclearFumes>(), 3, 5); //garanteed 3 to 5
                ConditionalDropItem(npc, ModContent.ItemType<NuclearFumes>(), Main.expertMode, 1, 3); //when expert mode you get 1 to 3
                ChanceDropItem(npc, ModContent.ItemType<NuclearFumes>(), 0.5f); //50% chance to get 1 extra
                ChanceDropItem(npc, ModContent.ItemType<NuclearFumes>(), 0.3f); //30% chance to get 1 extra
            }
            if (npc.type == calamityMod.NPCType("Cnidrion"))
            {
                ChanceDropItem(npc, ModContent.ItemType<DryShrimp>(), minibossChance);
            }
            if (npc.type == calamityMod.NPCType("Bumblefolly"))
            {
                ChanceDropItem(npc, ModContent.ItemType<OrbSummon>(), minibossChance);
            }
            if (npc.type == calamityMod.NPCType("Reaper"))
            {
                ChanceDropItem(npc, ModContent.ItemType<ReaperSharkArms>(), minibossChance);
            }
            if (npc.type == calamityMod.NPCType("ColossalSquid"))
            {
                ChanceDropItem(npc, ModContent.ItemType<SquidHat>(), minibossChance);
            }
            if (npc.type == calamityMod.NPCType("EidolonWyrmHead"))
            {
                ConditionalChanceDropItem(npc, ModContent.ItemType<EWail>(), Main.expertMode, minibossChance);
                ConditionalChanceDropItem(npc, ModContent.ItemType<SoulShard>(), !(bool)calamityMod.Call("GetBossDowned", "cryogen") && !NPC.downedGolemBoss && !NPC.downedPlantBoss && !NPC.downedAncientCultist, 1.0f);
            }
            if (npc.type == calamityMod.NPCType("EidolonWyrmHeadHuge"))
            {
                DropItem(npc, ModContent.ItemType<SoulShard>());
            }
            if (npc.type == calamityMod.NPCType("GreatSandShark") && Main.expertMode)
            {
                ConditionalChanceDropItem(npc, ModContent.ItemType<CrushedCore>(), Main.expertMode, minibossChance);
            }
            if (npc.type == calamityMod.NPCType("Horse"))
            {
                ChanceDropItem(npc, ModContent.ItemType<EarthShield>(), minibossChance);
            }
            if (npc.type == calamityMod.NPCType("GiantClam") && Main.expertMode)
            {
                ConditionalChanceDropItem(npc, ModContent.ItemType<ClamHermitMedallion>(), Main.expertMode, minibossChance);
                ChanceDropItem(npc, ModContent.ItemType<ClamMask>(), vanityMaxChance);
            }
            if (npc.type == NPCID.SandElemental)
            {
                ConditionalChanceDropItem(npc, ModContent.ItemType<SandBottle>(), Main.expertMode, normalChance);
                ConditionalChanceDropItem(npc, ModContent.ItemType<SandPlush>(), Main.expertMode, normalChance);
            }
            if (npc.type == calamityMod.NPCType("PlaguebringerShade"))
            {
                ConditionalChanceDropItem(npc, ModContent.ItemType<BeeCan>(), Main.expertMode, 0.1f);
                ConditionalChanceDropItem(npc, ModContent.ItemType<PlaugeWings>(), Main.expertMode, 0.1f);
                ConditionalChanceDropItem(npc, ModContent.ItemType<AncientAuricTeslaHelm>(), Main.expertMode, 0.0012f);
            }
            if (npc.type == calamityMod.NPCType("ArmoredDiggerHead"))
            {
                ConditionalChanceDropItem(npc, ModContent.ItemType<AncientAuricTeslaHelm>(), Main.expertMode, 0.0012f);
                ConditionalChanceDropItem(npc, ModContent.ItemType<WulfrumController>(), Main.expertMode, 0.1f);
            }
            if (npc.type == calamityMod.NPCType("CragmawMire"))
            {
                if (Main.expertMode)
                {
                    ConditionalChanceDropItem(npc, ModContent.ItemType<MawHook>(), (bool)calamityMod.Call("GetBossDowned", "polterghast"), 0.1f); //10%
                    ConditionalChanceDropItem(npc, ModContent.ItemType<MawHook>(), !(bool)calamityMod.Call("GetBossDowned", "polterghast"), 0.5f); //50% ?? why more??
                    ConditionalChanceDropItem(npc, ModContent.ItemType<NuclearFumes>(), (bool)calamityMod.Call("GetBossDowned", "polterghast"), 0.3f, 1, 3);
                }
            }
            //if (npc.type == mod.NPCType("NuclearTerror"))
            //{
            //if (Main.rand.NextFloat() < 0.1f && Main.expertMode)
            //{
            //Item.NewItem(npc.getRect(),
            //ModContent.ItemType<RadJuice>());
            //}
            //}
            if (npc.type == calamityMod.NPCType("ThiccWaifu"))
            {
                if (Main.expertMode)
                {
                    ConditionalChanceDropItem(npc, ModContent.ItemType<FogG>(), (bool)calamityMod.Call("GetBossDowned", "supremecalamitas"), 0.0001f);
                    ChanceDropItem(npc, ModContent.ItemType<cloudcandy>(), 0.1f);
                }
            }
            if (npc.type == calamityMod.NPCType("Mauler"))
            {
                ChanceDropItem(npc, ModContent.ItemType<MaulerMask>(), vanityNormalChance);
            }
            //Bosses
            if (npc.type == calamityMod.NPCType("Polterghast"))
            {
                int dropped = ConditionalChanceDropItem(npc, ModContent.ItemType<ToyScythe>(), (bool)calamityMod.Call("DifficultyActive", "revengeance"), bossPetChance);
                if (dropped == 0)
                    ConditionalDropItem(npc, ModContent.ItemType<ToyScythe>(), (bool)calamityMod.Call("DifficultyActive", "defiled"));
            }
            if (npc.type == calamityMod.NPCType("StormWeaverHeadNaked") && Main.expertMode)
            {
                ChanceDropItem(npc, ModContent.ItemType<AncientAuricTeslaHelm>(), 0.007f); //0.7%
                ChanceDropItem(npc, ModContent.ItemType<StormBandana>(), vanityNormalChance);
                ChanceDropItem(npc, Main.rand.NextBool() ? ModContent.ItemType<ShellScrap>() : ModContent.ItemType<WeaverFlesh>(), bossPetChance);
            }
            if (npc.type == calamityMod.NPCType("Bumblefuck"))
            {
                int dropped = ConditionalChanceDropItem(npc, ModContent.ItemType<FluffyFeather>(), (bool)calamityMod.Call("DifficultyActive", "revengeance"), bossPetChance);
                if (dropped == 0)
                    ConditionalDropItem(npc, ModContent.ItemType<FluffyFeather>(), (bool)calamityMod.Call("DifficultyActive", "defiled"));
                ConditionalChanceDropItem(npc, ModContent.ItemType<SparrowMeat>(), (bool)calamityMod.Call("DifficultyActive", "armageddon"), bossPetChance);
                ConditionalChanceDropItem(npc, ModContent.ItemType<FluffyFur>(), (bool)calamityMod.Call("DifficultyActive", "death"), 0.001f); //0.1%
            }
            if (npc.type == calamityMod.NPCType("AstrumAureus"))
            {
                int dropped = ConditionalChanceDropItem(npc, ModContent.ItemType<JellyBottle>(), (bool)calamityMod.Call("DifficultyActive", "revengeance"), bossPetChance);
                if (dropped == 0)
                    ConditionalDropItem(npc, ModContent.ItemType<JellyBottle>(), (bool)calamityMod.Call("DifficultyActive", "defiled"));
            }
            if (npc.type == calamityMod.NPCType("RavagerBody"))
            {
                ChanceDropItem(npc, ModContent.ItemType<ScavaHook>(), RIVChance);
                ConditionalDropItem(npc, ModContent.ItemType<Necrostone>(), !Main.expertMode, 135, 275);
            }
            if (npc.type == calamityMod.NPCType("Signus"))
            {
                ChanceDropItem(npc, ModContent.ItemType<SigCloth>(), bossPetChance);
                ChanceDropItem(npc, ModContent.ItemType<SigCape>(), vanityNormalChance);
                ChanceDropItem(npc, ModContent.ItemType<SignusNether>(), vanityNormalChance);
                ChanceDropItem(npc, ModContent.ItemType<SignusEmblem>(), vanityNormalChance);
                ConditionalChanceDropItem(npc, ModContent.ItemType<JunkoHat>(), (bool)calamityMod.Call("DifficultyActive", "revengeance"), 0.2f); //20%
                ConditionalChanceDropItem(npc, ModContent.ItemType<AncientAuricTeslaHelm>(), Main.expertMode, 0.007f); //0.7%
            }
            if (npc.type == calamityMod.NPCType("CeaselessVoid"))
            {
                ChanceDropItem(npc, ModContent.ItemType<VoidShard>(), bossPetChance);
                ConditionalChanceDropItem(npc, ModContent.ItemType<VoidShard>(), Main.expertMode, vanityNormalChance);
                ConditionalChanceDropItem(npc, ModContent.ItemType<VoidShard>(), Main.expertMode, 0.05f); //5%
                ConditionalChanceDropItem(npc, ModContent.ItemType<AncientAuricTeslaHelm>(), Main.expertMode, 0.007f); //0.7%
            }
            if (npc.type == calamityMod.NPCType("OldDuke") && Main.expertMode)
            {
                ChanceDropItem(npc, ModContent.ItemType<CharredChopper>(), RIVChance);
            }
            if (npc.type == calamityMod.NPCType("Yharon"))
            {
                if (!Main.expertMode)
                {
                    ConditionalDropItem(npc, ModContent.ItemType<Termipebbles>(), (bool)calamityMod.Call("GetBossDowned", "buffedeclipse"), 2, 8);
                }
            }
            if (npc.type == calamityMod.NPCType("SupremeCalamitas"))
            {
                ChanceDropItem(npc, ModContent.ItemType<AncientAuricTeslaHelm>(), 0.2f); //20%
            }

            //Profaned bike
            if (npc.type == calamityMod.NPCType("ProfanedGuardianBoss3") && Main.expertMode)
            {
                ChanceDropItem(npc, ModContent.ItemType<ProfanedBattery>(), 0.1f); //10%
            }
            if (npc.type == calamityMod.NPCType("ProfanedGuardianBoss2") && Main.expertMode)
            {
                ChanceDropItem(npc, ModContent.ItemType<ProfanedWheels>(), 0.1f); //10%
            }
            if (npc.type == calamityMod.NPCType("ProfanedGuardianBoss") && Main.expertMode)
            {
                ChanceDropItem(npc, ModContent.ItemType<ProfanedFrame>(), 0.1f); //10%
            }

            //Yharexs' Dev Pet (Calamity BABY)
            if ((bool)calamityMod.Call("DifficultyActive", "death"))
            {
                if (npc.type == calamityMod.NPCType("AstralSlime") && Main.rand.Next(870000) == 0)
                {
                    DropItem(npc, ModContent.ItemType<YharexsLetter>());
                }
                if (npc.type == calamityMod.NPCType("SupremeCalamitas"))
                {
                    bool didIGetHit = false;
                    for (int i = 0; i < Main.maxPlayers; i++)
                    {
                        Player player = Main.player[i];
                        if (player.active && !player.dead)
                        {
                            if (player.GetModPlayer<CalValEXPlayer>().SCalHits > 0)
                            {
                                didIGetHit = true;
                            }
                        }
                    }
                    if (!didIGetHit)
                    {
                        DropItem(npc, ModContent.ItemType<YharexsLetter>());
                    }
                    else
                    {
                        if (Main.rand.Next(1000) == 0)
                        {
                            DropItem(npc, ModContent.ItemType<YharexsLetter>());
                        }
                    }
                }
            }
        }

        private static int DropItem(NPC npc, int itemID, bool dropPerPlayer, int min = 1, int max = 0)
        {
            int numberOfItems;
            if (max <= min)
                numberOfItems = min;
            else
                numberOfItems = Main.rand.Next(min, max + 1);

            if (numberOfItems <= 0)
                return 0;

            if (dropPerPlayer)
                npc.DropItemInstanced(npc.position, npc.Size, itemID, numberOfItems);
            else
                Item.NewItem(npc.Hitbox, itemID, numberOfItems);
            return numberOfItems;
        }

        private static int DropItem(NPC npc, int itemID, int min = 1, int max = 0) => DropItem(npc, itemID, false, min, max);

        public static int ChanceDropItem(NPC npc, int itemID, float chance, bool dropPerPlayer, int min = 1, int max = 0)
        {
            if (Main.rand.NextFloat() < chance)
                return DropItem(npc, itemID, dropPerPlayer, min, max);
            return 0;
        }

        public static int ChanceDropItem(NPC npc, int itemID, float chance, int min = 1, int max = 0) => ChanceDropItem(npc, itemID, chance, false, min, max);

        public static int ConditionalDropItem(NPC npc, int itemID, bool condition, bool dropPerPlayer, int min = 1, int max = 0)
        {
            if (condition)
                return DropItem(npc, itemID, dropPerPlayer, min, max);
            return 0;
        }

        public static int ConditionalDropItem(NPC npc, int itemID, bool condition, int min = 1, int max = 0) => ConditionalDropItem(npc, itemID, condition, false, min, max);

        public static int ConditionalChanceDropItem(NPC npc, int itemID, bool condition, float chance, bool dropPerPlayer, int min = 1, int max = 0)
        {
            if (condition)
                return ChanceDropItem(npc, itemID, chance, dropPerPlayer, min, max);
            return 0;
        }

        public static int ConditionalChanceDropItem(NPC npc, int itemID, bool condition, float chance, int min = 1, int max = 0) => ConditionalChanceDropItem(npc, itemID, condition, chance, false, min, max);
    }
}
