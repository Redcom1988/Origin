using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
namespace Origin.Items.Weapons
{
    public class Jarate : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Jarate");
            Tooltip.SetDefault("AUSTRALIA!!");

        }


        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 24;
            item.autoReuse = true;
            item.value = Terraria.Item.sellPrice(0, 0, 60, 0);
            item.value = Item.buyPrice(0, 2, 0, 0);
            item.rare = ItemRarityID.Orange;
            item.damage = 87;
            item.thrown = true;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useTime = 20;
            item.useAnimation = 20;
            item.noMelee = true;
            item.shoot = ProjectileID.MolotovCocktail;
            item.shootSpeed = 12f;
            item.UseSound = SoundID.Item107;
            item.consumable = true;
            item.maxStack = 99;
        }
        //public override void AddRecipes()
        //{
        //ModRecipe modRecipe = new ModRecipe(mod);
        //modRecipe.AddIngredient(ModContent.ItemType<Urine>(), 8);
        //modRecipe.AddTile(TileID.WorkBenches);
        //modRecipe.SetResult(this, 5);
        //modRecipe.AddRecipe();

        public override void AddRecipes()
        {
            ModRecipe modRecipe = new ModRecipe(mod);
            modRecipe.AddIngredient(ItemID.Ichor, 3);
            modRecipe.SetResult(this, 10);
            modRecipe.AddRecipe();
        }
    }
}
