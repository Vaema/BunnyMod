using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BunnyMod.NPCs;

public abstract class BaseBunny : ModNPC
{
    public virtual int CatchItem { get; set; } 
    
    public virtual int DustType { get; set; }

    public override void SetStaticDefaults() =>
        Main.npcFrameCount[Type] = 7;

    public override void SetDefaults()
    {
        NPC.width = 28;
        NPC.height = 24;

        NPC.lifeMax = 5;
        NPC.damage = 0;
        NPC.defense = 0;
        NPC.friendly = true;
        NPC.knockBackResist = 0.5f;
        NPC.catchItem = CatchItem;

        NPC.aiStyle = 7;
        AIType = 46;
        AnimationType = 46;

        NPC.HitSound = SoundID.NPCHit1;
        NPC.DeathSound = SoundID.NPCDeath1;
    }

    public override void HitEffect(NPC.HitInfo hit)
    {
        if (NPC.life <= 0)
        {
            for (int i = 0; i < 5; i++)
            {
                int dust = Dust.NewDust(NPC.Center, NPC.width / 2, NPC.height / 2, DustType,
                    (0f - NPC.velocity.X) * 0.2f, (0f - NPC.velocity.Y) * 0.2f, 100, default, 2f);
                Main.dust[dust].velocity *= 2f;
            }
        }
    }

    public override bool CanHitPlayer(Player target, ref int cooldownSlot) => false;
}