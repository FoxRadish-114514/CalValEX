using Terraria.ModLoader;
using CalValEX.Tiles.FurnitureSets.Wulfrum;
using Terraria.ID;

namespace CalValEX.Items.Tiles.FurnitureSets.Wulfrum
{
    public class WulfrumGlobe : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Wulfrum Globe");
            // Tooltip.SetDefault("Spin spin spin");
            Item.ResearchUnlockCount = 1;
        }

        public override void SetDefaults()
        {
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;
            Item.maxStack = 99;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<WulfrumGlobePlaced>();
            Item.width = 12;
            Item.height = 12;
            Item.rare = ItemRarityID.Green;
        }
    }
}