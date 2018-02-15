using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NeoNGhost.Projectiles
{
	public class Carrow : ModProjectile
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Carrow");
        }

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.WoodenArrowFriendly);
            aiType = ProjectileID.WoodenArrowFriendly;
            projectile.height = 18;
            projectile.light = 0;
        }
        public override void OnHitNPC(NPC target, int damage, float knockBack, bool crit)
        {
            target.AddBuff(31, 3 * 60);
        }
				
	}
}
