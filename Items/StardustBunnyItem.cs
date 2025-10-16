using BunnyMod.NPCs;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BunnyMod.Items;

public class StardustBunnyItem : BaseBunnyItem
{
    public override void SafeSetDefaults()
    {
        Item.makeNPC = ModContent.NPCType<StardustBunny>();
        Item.rare = ItemRarityID.Orange;
        Item.value = Item.sellPrice(silver: 10);
    }
}