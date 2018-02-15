using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NeoNGhost.Projectiles
{
	public class GraniteChakram : ModProjectile
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("GraniteChakram");
        }
        public override void SetDefaults()
        {    
            projectile.width = 40;
            projectile.height = 40;
            projectile.aiStyle = 3;
            projectile.friendly = true;
            projectile.ownerHitCheck = true; //so you can't hit enemies through walls
            projectile.melee = true;
            projectile.timeLeft = 600;
            projectile.extraUpdates = 1;
            projectile.penetrate = -1;
            drawOffsetX = 2;
            drawOriginOffsetY = 2;
        }
		
	}
}
