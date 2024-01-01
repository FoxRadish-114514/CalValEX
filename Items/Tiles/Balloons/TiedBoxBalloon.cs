using Terraria.ModLoader;
using CalValEX.Tiles.Balloons;
using Terraria.ID;

namespace CalValEX.Items.Tiles.Balloons
{
    public class TiedBoxBalloon : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Tied Box Balloon");
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
            Item.createTile = ModContent.TileType<TiedBoxBalloonPlaced>();
            Item.width = 16;
            Item.height = 40;
            Item.rare = ItemRarityID.LightRed;
        }
    }
}