using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NeoNGhost.Projectiles
{
	public class Carrot : ModProjectile
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Carrot");
        }
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.Bullet);
            aiType = ProjectileID.Bullet;
            projectile.height = 18;
            projectile.light = 0;
        }
        public override void OnHitNPC(NPC target, int damage, float knockBack, bool crit)
        {
            target.AddBuff(164, 3 * 60);
        }
				
	}
}
