using BunnyMod.Items;

using Terraria.ID;
using Terraria.ModLoader;

namespace BunnyMod.NPCs;

public class StardustBunny : BaseBunnyNPC
{
    public override int CatchItem => ModContent.ItemType<StardustBunnyItem>();

    public override int DustType => DustID.BlueTorch;

    public override float SpawnChance(NPCSpawnInfo spawnInfo)
    {
        if (!spawnInfo.Player.ZoneTowerStardust)
            return 0f;

        return 0.2f;
    }
}