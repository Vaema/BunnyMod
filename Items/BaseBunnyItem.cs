using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BunnyMod.Items;

public abstract class BaseBunnyItem : ModItem
{
    public override void SetStaticDefaults() =>
        Item.ResearchUnlockCount = 5;

    public override void SetDefaults()
    {
        Item.width = 26;
        Item.height = 24;
        Item.useStyle = ItemUseStyleID.Swing;
        Item.autoReuse = true;
        Item.useTurn = true;
        Item.useAnimation = 15;
        Item.useTime = 10;
        Item.maxStack = 9999;
        Item.consumable = true;
        Item.noUseGraphic = true;
        SafeSetDefaults();
    }

    public virtual void SafeSetDefaults() { }
}