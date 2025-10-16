using BunnyMod.Items;

using Terraria.ID;
using Terraria.ModLoader;

namespace BunnyMod.NPCs;

public class VortexBunny : BaseBunnyNPC
{
    public override int CatchItem => ModContent.ItemType<VortexBunnyItem>();

    public override int DustType => DustID.Vortex;

    public override float SpawnChance(NPCSpawnInfo spawnInfo)
    {
        if (!spawnInfo.Player.ZoneTowerVortex)
            return 0f;

        return 0.2f;
    }
}