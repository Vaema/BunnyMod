using BunnyMod.Items;

using Terraria.ID;
using Terraria.ModLoader;

namespace BunnyMod.NPCs;

public class HallowedBunny : BaseBunnyNPC
{
    public override int CatchItem => ModContent.ItemType<HallowedBunnyItem>();

    public override int DustType => DustID.PinkCrystalShard;
}