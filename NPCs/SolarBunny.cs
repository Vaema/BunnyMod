using BunnyMod.Items;

using Terraria.ID;
using Terraria.ModLoader;

namespace BunnyMod.NPCs;

public class SolarBunny : BaseBunnyNPC
{
    public override int CatchItem => ModContent.ItemType<SolarBunnyItem>();

    public override int DustType => DustID.SolarFlare;

    public override float SpawnChance(NPCSpawnInfo spawnInfo)
    {
        if (!spawnInfo.Player.ZoneTowerSolar)
            return 0f;

        return 0.2f;
    }
}