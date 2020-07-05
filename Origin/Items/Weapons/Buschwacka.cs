using IL.Terraria.ID;
using On.Terraria.ID;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;

namespace Origin.Items.Weapons
{
    public class Buschwacka : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Buschwacka");
            Tooltip.SetDefault("Piss Knife");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 24;
            item.autoReuse = true;
            item.value = Terraria.Item.sellPrice(0, 0, 60, 0);
            item.value = Terraria.Item.buyPrice(0, 2, 0, 0);
            item.rare = ItemRarityID.Yellow;
            item.damage = 44;
            item.melee = true;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useTime = 23;
            item.useAnimation = 23;
            item.channel = true;
            item.UseSound = Terraria.ID.SoundID.Item107;
            item.shoot = Terraria.ID.ProjectileID.MolotovCocktail;
            item.shootSpeed = 12f;
        }

        public override void AddRecipes()
        {
            ModRecipe modRecipe = new ModRecipe(mod);
            modRecipe.AddIngredient(Terraria.ID.ItemID.DirtBlock, 0);
            modRecipe.SetResult(this);
            modRecipe.AddRecipe();
        }
    }
}    
