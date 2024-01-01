using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalValEX.Items.Equips.Backs
{
    [AutoloadEquip(EquipType.Back)]
    public class BackpackServer : ModItem
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
        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            //rarity 12 (Turquoise) = new Color(0, 255, 200)
            //rarity 13 (Pure Green) = new Color(0, 255, 0)
            //rarity 14 (Dark Blue) = new Color(43, 96, 222)
            //rarity 15 (Violet) = new Color(108, 45, 199)
            //rarity 16 (Hot Pink/Developer) = new Color(255, 0, 255)
            //rarity rainbow (no expert tag on item) = new Color(Main.DiscoR, Main.DiscoG, Main.DiscoB)
            //rarity rare variant = new Color(255, 140, 0)
            //rarity dedicated(patron items) = new Color(139, 0, 0)
            //look at https://calamitymod.gamepedia.com/Rarity to know where to use the colors
            foreach (TooltipLine tooltipLine in tooltips)
            {
                if (tooltipLine.Mod == "Terraria" && tooltipLine.Name == "ItemName")
                {
                    tooltipLine.OverrideColor = new Color(204, 71, 35); //change the color accordingly to above
                }
            }
        }

        /*public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
           
            if (calamityMod != null)
            {
                recipe.AddIngredient(calamityMod.ItemType("DubiousPlating"), 5);
                recipe.AddIngredient(calamityMod.ItemType("MysteriousCircuitry"), 5);
                recipe.AddTile(ModLoader.GetMod("CalamityMod").TileType("LaboratoryConsole"));
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }*/
    }
}