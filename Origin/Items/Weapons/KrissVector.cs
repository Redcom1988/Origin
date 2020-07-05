using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace Origin.Items.Weapons
{
    public class KrissVector : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Kriss Vector");
            Tooltip.SetDefault("SMG Primary");
        }

        public override void SetDefaults()
        {
            item.damage = 17;
            item.knockBack = 3;
            item.shoot = ProjectileID.Bullet;
            item.shootSpeed = 16;

            item.ranged = true;
            item.noMelee = true;

            item.height = 24;
            item.width = 24;

            item.useTime = 5;
            item.useAnimation = 8;
            item.autoReuse = true;

            item.value = 1000;
            item.rare = ItemRarityID.Yellow;

            item.useStyle = ItemUseStyleID.HoldingOut;
            item.UseSound = SoundID.Item11;
            item.useAmmo = AmmoID.Bullet;
        }

        public override void AddRecipes()
        {
            ModRecipe modRecipe = new ModRecipe(mod);
            modRecipe.AddIngredient(ItemID.IllegalGunParts, 4);
            modRecipe.AddIngredient(ItemID.IronBar, 5);
            modRecipe.AddTile(TileID.Anvils);
            modRecipe.SetResult(this);
            modRecipe.AddRecipe();
        }
    }
}
