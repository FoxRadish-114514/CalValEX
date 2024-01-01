using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;

// If you don't know what to change this to, don't mess with this code.
// You will fail
namespace CalValEX.Projectiles.Pets
{
    public class FathomEelHead : ModProjectile
    {
        private static readonly int SegmentCount = 7;
        private bool SpawnedSegments = false;
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Fathom Eel");
            ProjectileID.Sets.NeedsUUID[Projectile.type] = true;
            Main.projPet[Projectile.type] = true;
        }

        public override void SetDefaults()
        {
            Projectile.width = 26;
            Projectile.height = 36;
            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.ignoreWater = true;
            Projectile.netImportant = true;
            Projectile.penetrate = -1;
            Projectile.timeLeft = 300;
            Projectile.tileCollide = false;
        }

        public override void AI()
        {
            if (!SpawnedSegments)
            {
                int tail = Projectile.NewProjectile(Projectile.GetSource_FromThis(), Projectile.Center, Vector2.Zero, ModContent.ProjectileType<FathomEelTail>(),
                    Projectile.damage, Projectile.knockBack, 0, Projectile.whoAmI);
                // The minus one is because this segment and the tail are incorporated in the worm as well
                for (int i = 0; i < SegmentCount - 2; i++)
                {
                    float uuid = (float)Projectile.GetByUUID(Main.myPlayer, Main.projectile[tail].ai[0]);
                    int body = Projectile.NewProjectile(Projectile.GetSource_FromThis(), Projectile.Center, Vector2.Zero,
                        ModContent.ProjectileType<FathomEelBody>(), Projectile.damage, 1f,
                        0, uuid);
                    int back = Projectile.NewProjectile(Projectile.GetSource_FromThis(), Projectile.Center, Vector2.Zero,
                        ModContent.ProjectileType<FathomEelBody>(), Projectile.damage, 1f,
                        0, (float)body);
                    if (i == 1 || i == 3)
                    {
                        Main.projectile[body].knockBack = 2f;
                    }
                    else if (i == 0 || i == 2 || i == 4)
                    {
                        Main.projectile[body].knockBack = 3f;
                    }
                    else if (i == 5)
                    {
                        Main.projectile[body].knockBack = 4f;
                        Main.projectile[body].DamageType = DamageClass.Ranged;
                    }
                    Main.projectile[body].ai[1] = 1f;
                    Main.projectile[body].netUpdate = true;
                    Main.projectile[body].identity = Projectile.whoAmI;

                    Main.projectile[back].netUpdate = true;
                    Main.projectile[back].ai[1] = 1f;
                    Main.projectile[body].identity = Projectile.whoAmI;

                    Main.projectile[tail].ai[0] = Main.projectile[body].projUUID;
                    Main.projectile[tail].netUpdate = true;
                    Main.projectile[tail].ai[1] = 1f;
                }
                SpawnedSegments = true;
            }
            // Consistently update the worm
            if ((int)Main.time % 120 == 0)
            {
                Projectile.netUpdate = true;
            }

            // Custom AI here
            Player player = Main.player[Projectile.owner];
            CalValEXPlayer modPlayer = player.GetModPlayer<CalValEXPlayer>();
            if (player.dead)
            {
                modPlayer.feel = false;
            }
            if (modPlayer.feel)
            {
                Projectile.timeLeft = 2;
            }

            Vector2 PlayerCenter = player.Center;
            float MinVel = 0.36f;
            Vector2 ProjDistance = PlayerCenter - Projectile.Center;
            if (ProjDistance.Length() < 100f)
            {
                MinVel = 0.22f;
            }
            if (ProjDistance.Length() < 80f)
            {
                MinVel = 0.1f;
            }
            if (ProjDistance.Length() > 50f)
            {
                if (Math.Abs(PlayerCenter.X - Projectile.Center.X) > 10f)
                {
                    Projectile.velocity.X = Projectile.velocity.X + MinVel * (float)Math.Sign(PlayerCenter.X - Projectile.Center.X);
                }
                if (Math.Abs(PlayerCenter.Y - Projectile.Center.Y) > 5f)
                {
                    Projectile.velocity.Y = Projectile.velocity.Y + MinVel * (float)Math.Sign(PlayerCenter.Y - Projectile.Center.Y);
                }
            }
            else if (Projectile.velocity.Length() > 1.6f)
            {
                Projectile.velocity *= 0.96f;
            }
            float MaxVel = 15f;
            if (ProjDistance.Length() > 800f)
            {
                MaxVel = 25;
            }
            else if (ProjDistance.Length() > 500f)
            {
                MaxVel = 22f;
            }
            else if (ProjDistance.Length() > 300f)
            {
                MaxVel = 18.5f;
            }
            else
            {
                MaxVel = 15;
            }


            if (Projectile.velocity.Length() > MaxVel)
            {
                Projectile.velocity = Vector2.Normalize(Projectile.velocity) * MaxVel;
            }
            if (ProjDistance.Length() > 2000f)
            {
                Projectile.Center = PlayerCenter;
            }
            if (Math.Abs(Projectile.velocity.Y) < 1f)
            {
                Projectile.velocity.Y = Projectile.velocity.Y - 0.1f;
            }
            // NOTE: If you wish for this worm to travel at very high speeds, the
            // Body and tail segments will gain gaps. You would have to change the position adjusting
            // In the body and tail's code to mitigate this problem.

            Projectile.rotation = Projectile.velocity.ToRotation() + MathHelper.PiOver2;

            int oldDirection = Projectile.direction;
            Projectile.direction = (Projectile.velocity.X > 0f).ToDirectionInt();

            // Update the projectile in multiplayer if the determined direction is not the true direction.
            // It will do weird things in multiplayer because of a lack of syncing among the directions
            if (oldDirection != Projectile.direction)
            {
                Projectile.netUpdate = true;
            }

            Projectile.position = Projectile.Center;
            Projectile.width = 26;
            Projectile.height = 36;
            Projectile.Center = Projectile.position;
        }
        public override void PostDraw(Color lightColor)
        {
            Texture2D texture = ModContent.Request<Texture2D>("CalValEX/Projectiles/Pets/FathomEelHead_Glow").Value;
            int frameHeight = texture.Height / Main.projFrames[Projectile.type];
            int hei = frameHeight * Projectile.frame;
            Main.EntitySpriteDraw(texture, Projectile.Center - Main.screenPosition, new Microsoft.Xna.Framework.Rectangle?(new Rectangle(0, frameHeight * Projectile.frame, texture.Width, frameHeight)), lightColor, Projectile.rotation, Projectile.Size / 2f, 1f, SpriteEffects.None, 0);
        }
    }
}
