using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using CalValEX.Tiles.Statues;

namespace CalValEX.Items.Tiles.Statues
{
    public class EyedolStatue : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Eyedol Statue");
            Item.ResearchUnlockCount = 1;
        }

        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.ArmorStatue);
            Item.createTile = TileType<EyedolStatuePlaced>();
            Item.placeStyle = 0;
        }

        /*public override void AddRecipes()
        {
            Mod CalValEX = ModLoader.GetMod("CalamityMod");
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ModContent.ItemType<EyedolItem>(), 5);
                recipe.AddIngredient((ItemID.StoneBlock), 50);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }*/
    }
}