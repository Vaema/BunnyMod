using BunnyMod.NPCs;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BunnyMod.Items;

public class VortexBunnyItem : BaseBunnyItem
{
    public override void SafeSetDefaults()
    {
        Item.makeNPC = ModContent.NPCType<VortexBunny>();
        Item.rare = ItemRarityID.Red;
        Item.value = Item.sellPrice(gold: 1);
    }
}