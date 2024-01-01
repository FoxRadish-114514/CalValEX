﻿using Terraria.ID;
using Terraria.ModLoader;
using CalValEX.Tiles.AstralBlocks;

namespace CalValEX.Items.Tiles.Blocks
{
    public class AstralBrick : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Blighted Astral Brick");
            Item.ResearchUnlockCount = 100;
        }
        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;
            Item.maxStack = 999;
            Item.rare = ItemRarityID.White;
            Item.useTurn = true;
            Item.rare = ItemRarityID.White;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<AstralBrickPlaced>();
        }

        /*/*
        {
            Mod CalValEX = ModLoader.GetMod("CalamityMod");
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient((ItemID.StoneBlock), 1);
                recipe.AddIngredient(ModContent.ItemType<Xenostone>(), 1);
                recipe.AddTile(ModContent.TileType<StarstruckSynthesizerPlaced>());
                recipe.SetResult(this);
                recipe.AddRecipe();
                ModRecipe recipe2 = new ModRecipe(mod);
                recipe2.AddIngredient(mod.ItemType("AstralBrickWall"), 4);
                recipe2.AddTile(TileID.WorkBenches);
                recipe2.SetResult(this);
                recipe2.AddRecipe();
            }
        }*/
    }
}