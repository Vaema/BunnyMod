using BunnyMod.NPCs;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BunnyMod.Items;

public class HallowedBunnyItem : BaseBunnyItem
{
    public override void SafeSetDefaults()
    {
        Item.makeNPC = ModContent.NPCType<HallowedBunny>();
        Item.rare = ItemRarityID.Pink;
        Item.value = Item.sellPrice(silver: 15);
    }
}