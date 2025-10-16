using BunnyMod.Items;

using Terraria.ID;
using Terraria.ModLoader;

namespace BunnyMod.NPCs;

public class NebulaBunny : BaseBunnyNPC
{
    public override int CatchItem => ModContent.ItemType<NebulaBunnyItem>();

    public override int DustType => DustID.PurpleTorch;

    public override float SpawnChance(NPCSpawnInfo spawnInfo)
    {
        if (!spawnInfo.Player.ZoneTowerNebula)
            return 0f;

        return 0.2f;
    }
}