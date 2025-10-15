using BunnyMod.Items;

using Terraria.ID;
using Terraria.ModLoader;

namespace BunnyMod.NPCs;

public class HellBunny : BaseBunnyNPC
{
    public override int CatchItem => ModContent.ItemType<HellBunnyItem>();

    public override int DustType => DustID.Torch;

    public override float SpawnChance(NPCSpawnInfo spawnInfo)
    {
        if (!spawnInfo.Player.ZoneUnderworldHeight)
            return 0f;

        return 0.2f;
    }
}