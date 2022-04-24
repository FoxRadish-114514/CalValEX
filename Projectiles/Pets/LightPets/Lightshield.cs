/*using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CalValEX.Projectiles.Pets.LightPets
{
    public class Lightshield : ModProjectile
    {
        public override string Texture => "CalamityMod/NPCs/Cryogen/CryogenIce";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Arctic Shield");
            Main.projFrames[Projectile.type] = 1;
            Main.projPet[Projectile.type] = true;
            ProjectileID.Sets.LightPet[Projectile.type] = true;
        }

        public override void SetDefaults()
        {
            Projectile.damage = 0;
            Projectile.friendly = true;
            Projectile.tileCollide = false;
            Projectile.ignoreWater = true;
            Projectile.hostile = false;
            Projectile.width = 222;
            Projectile.height = 216;
            Projectile.aiStyle = -1;
            Projectile.netImportant = true;
        }

        public override bool? CanCutTiles()
        {
            return false;
        }

        public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
        {
            //Lighting.AddLight(Projectile.Center, new Vector3(0.541176471f, 1f, 1f));
            Texture2D texture = Main.projectileTexture[Projectile.type];
            Main.EntitySpriteDraw(texture, Projectile.Center - Main.screenPosition, null, Projectile.GetAlpha(lightColor), Projectile.rotation, new Vector2(texture.Width / 2, texture.Height / 2), 1f, Projectile.spriteDirection == 1 ? SpriteEffects.None : SpriteEffects.None, 0f);
            return false;
        }

        public override void AI()
        {
            Player player = Main.player[Projectile.owner];

            CalValEXPlayer modPlayer = player.GetModPlayer<CalValEXPlayer>();

            if (player.dead)
                modPlayer.Lightshield = false;
            if (modPlayer.Lightshield)
                Projectile.timeLeft = 2;

            Vector2 idlePosition = player.Center;
            idlePosition.Y -= Projectile.height / 2;
            idlePosition.X -= Projectile.width / 2;
            Projectile.position = idlePosition;
            Projectile.spriteDirection = 1;

            Projectile.rotation += 0.05f;
            if (Projectile.rotation > MathHelper.TwoPi)
            {
                Projectile.rotation -= MathHelper.TwoPi;
            }
            else if (Projectile.rotation < 0)
            {
                Projectile.rotation += MathHelper.TwoPi;
            }
        }
    }
}*/