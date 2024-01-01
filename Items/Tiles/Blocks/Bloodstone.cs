using Terraria;
using Terraria.ModLoader;


namespace CalValEX.Items.Tiles.Blocks
{
    public class Bloodstone : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Compensation");
            // Tooltip.SetDefault("Can be sold");
            Item.ResearchUnlockCount = 100;
        }

        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;
            Item.maxStack = 999;
            Item.value = Item.sellPrice(0, 0, 1, 0);
            Item.rare = -1;
        }
    }
}