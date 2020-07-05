using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace Origin.Items.Weapons
{
    public class TommyGun : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Thompson");
            Tooltip.SetDefault("SMG Primary");
        }

        public override void SetDefaults()
        {
            item.damage = 21;
            item.knockBack = 3;
            item.shoot = ProjectileID.Bullet;
            item.shootSpeed = 16;

            item.ranged = true;
            item.noMelee = true;

            item.height = 24;
            item.width = 24;

            item.useTime = 6;
            item.useAnimation = 6;
            item.autoReuse = true;
            
            item.value = 1000;
            item.rare = ItemRarityID.Quest;

            item.useStyle = ItemUseStyleID.HoldingOut;
            item.UseSound = SoundID.Item11;
            item.useAmmo = AmmoID.Bullet;
        }

        public override void AddRecipes()
        {
            ModRecipe modRecipe = new ModRecipe(mod);
            modRecipe.AddIngredient(ItemID.IllegalGunParts, 4);
            modRecipe.AddIngredient(ItemID.IronBar, 3);
            modRecipe.AddTile(TileID.Anvils);
            modRecipe.SetResult(this);
            modRecipe.AddRecipe();
        }
    }
}
