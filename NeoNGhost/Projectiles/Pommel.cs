using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NeoNGhost.Projectiles
{
	public class Pommel : ModProjectile
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pommel");
        }
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.SnowBallFriendly);
			projectile.thrown = false;
            projectile.melee = true;
            aiType = ProjectileID.SnowBallFriendly;			
			
        }
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            Main.PlaySound(SoundID.Item37, projectile.position);
            projectile.Kill();
            return false;
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            Main.PlaySound(SoundID.Item37, projectile.position);
            projectile.Kill();
        }


    }
}
