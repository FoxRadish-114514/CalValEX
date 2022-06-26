﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CalValEX.Projectiles.Plushies;
//using CalValEX.Items.Tiles.Plushies;

namespace CalValEX.Items.Plushies
{
    public class DesertScourgePlushThrowable : ModItem
    {
        public override string Texture => "CalValEX/Items/Tiles/Plushies/DesertScourgePlush";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Desert Scourge Plushie (Throwable)");
            Tooltip.SetDefault("Can be thrown");
            SacrificeTotal = 1;
        }

        public override void SetDefaults()
        {
            Item.useStyle = 1;
            Item.width = 44;
            Item.height = 44;
            Item.consumable = true;
            Item.UseSound = SoundID.Item1;
            Item.rare = 1;
            Item.useAnimation = 20;
            Item.useTime = 20;
            Item.noUseGraphic = true;
            Item.noMelee = true;
            Item.value = 20;
            Item.shoot = ModContent.ProjectileType<DesertScourgePlush>();
            Item.shootSpeed = 6f;
            Item.maxStack = 99;
        }

        /*public override void AddRecipes()
        {
            
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ModContent.ItemType<Items.Tiles.Plushies.DesertScourgePlush>());
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }*/
    }
}