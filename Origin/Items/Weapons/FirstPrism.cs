using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace Origin.Items.Weapons
{
    public class FirstPrism : ModItem
    {


        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("First Prism");
            Tooltip.SetDefault("A bad parody of the last prism");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.LastPrism);
            item.mana = 4;
            item.damage = 42;
            item.shoot = ProjectileID.LastPrism;
            item.shootSpeed = 30f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1000);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool CanUseItem(Player player) => player.ownedProjectileCounts[ProjectileID.LastPrismLaser] <= 623;
    }
}