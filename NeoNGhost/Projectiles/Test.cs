using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
namespace NeoNGhost.Projectiles
{
	public class Test : ModProjectile
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Test");
        }

        public override void SetDefaults()
        {

            projectile.light = 1;
            projectile.height = 60;
            projectile.width = 60;
            projectile.tileCollide = false;
            projectile.penetrate = -1;

        }
        public override void AI()
        {
            Player projOwner = Main.player[projectile.owner];
            projectile.direction = projOwner.direction;

            if (projectile.direction == 1)
            { projectile.position.X = Main.player[projectile.owner].Center.X - projectile.width / 2 - 8; }
                else
            { projectile.position.X = Main.player[projectile.owner].Center.X - projectile.width / 2 + 20; }
            projectile.position.Y = Main.player[projectile.owner].Center.Y - projectile.height / 2 - 15;

            projectile.spriteDirection = -projectile.direction;
        }

    }
}
