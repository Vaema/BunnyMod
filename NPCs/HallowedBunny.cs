using BunnyMod.Items;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BunnyMod.NPCs;

public class HallowedBunny : BaseBunnyNPC
{
    public override int CatchItem => ModContent.ItemType<HallowedBunnyItem>();

    public override int DustType => DustID.PinkCrystalShard;

    public override float SpawnChance(NPCSpawnInfo spawnInfo)
    {
        if (!(spawnInfo.SpawnTileY < Main.worldSurface || spawnInfo.Player.ZoneHallow))
            return 0f;

        return 0.2f;
    }
}