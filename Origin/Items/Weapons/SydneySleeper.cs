using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace Origin.Items.Weapons
{
    public class SydneySleeper : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sydney Sleeper");
            Tooltip.SetDefault("Piss Rifle");
        }

        public override void SetDefaults()
        {
            item.damage = 150;
            item.knockBack = 3;
            item.shoot = ProjectileID.Bullet;
            item.shootSpeed = 10;

            item.ranged = true;
            item.noMelee = true;

            item.height = 24;
            item.width = 24;

            item.useTime = 35;
            item.useAnimation = 35;
            item.autoReuse = false;

            item.value = 1000;
            item.rare = ItemRarityID.Yellow;

            item.useStyle = ItemUseStyleID.HoldingOut;
            item.UseSound = SoundID.Item11;
            item.useAmmo = AmmoID.Bullet;
        }

        public override void AddRecipes()
        {
            ModRecipe modRecipe = new ModRecipe(mod);
            modRecipe.AddIngredient(ItemID.IllegalGunParts, 6);
            modRecipe.AddIngredient(ItemID.IronBar, 12);
            modRecipe.AddTile(TileID.Anvils);
            modRecipe.SetResult(this);
            modRecipe.AddRecipe();
        }
    }
}
