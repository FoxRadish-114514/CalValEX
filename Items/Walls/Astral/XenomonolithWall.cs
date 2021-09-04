﻿using Terraria.ID;
using Terraria.ModLoader;
using CalValEX.Items.Tiles.Blocks.Astral;
using CalValEX.Walls.AstralSafe;

namespace CalValEX.Items.Walls.Astral
{
    public class XenomonolithWall : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Xenomonolith Wall");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            item.rare = 0;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 7;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.createWall = ModContent.WallType<XenomonolithWallPlaced>();
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<AstralTreeWood>(), 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 4);
            recipe.AddRecipe();
            ModRecipe recipe2 = new ModRecipe(mod);
            recipe2.AddIngredient(ModLoader.GetMod("CalamityMod").ItemType("AstralMonolithWall"));
            recipe2.AddTile(mod.TileType("StarstruckSynthesizerPlaced"));
            recipe2.SetResult(this);
            recipe2.AddRecipe();
        }
    }
}