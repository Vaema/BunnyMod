using BunnyMod.NPCs;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BunnyMod.Items;

public class NebulaBunnyItem : BaseBunnyItem
{
    public override void SafeSetDefaults()
    {
        Item.makeNPC = ModContent.NPCType<NebulaBunny>();
        Item.rare = ItemRarityID.Orange;
        Item.value = Item.sellPrice(silver: 10);
    }
}