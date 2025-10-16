using BunnyMod.NPCs;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BunnyMod.Items;

public class SolarBunnyItem : BaseBunnyItem
{
    public override void SafeSetDefaults()
    {
        Item.makeNPC = ModContent.NPCType<SolarBunny>();
        Item.rare = ItemRarityID.Red;
        Item.value = Item.sellPrice(gold: 1);
    }
}