﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;

namespace CalValEX.Projectiles.Boi
{
    public class BoiUI : ModProjectile
    {
        //Variable gore
        public bool spawnana = false;
        public bool spawnstuff = false;
        public bool setfield = false;
        public int roomcool = 0;
        public int localboistage = 0;
        public override string Texture => "CalValEX/ExtraTextures/Pong/PongBG";

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Boi UI");
            Main.projFrames[Projectile.type] = 1;
        }

        public override void SetDefaults()
        {
            Projectile.width = 832;
            Projectile.height = 512;
            Projectile.aiStyle = -1;
            Projectile.ignoreWater = true;
            Projectile.tileCollide = false;
            Projectile.timeLeft = 18000;
        }

        public override void AI()
        {
            Player player = Main.player[Projectile.owner];
            CalValEXPlayer modPlayer = player.GetModPlayer<CalValEXPlayer>();

            modPlayer.boiactive = true;

            //Assure that the screen is locked on the player
            Projectile.position.X = player.position.X - 400;
            Projectile.position.Y = player.position.Y - 240;

            //Close the screen
            if (player.controlMount)
            {
                modPlayer.boistage = 0;
                modPlayer.boiactive = false;
                Projectile.active = false;
            }
            //The juicy part
            if (modPlayer.boiactive)
            {
                //If the initial contents of the game haven't been spawned, spawn them
                if (!spawnana)
                {
                    //Spawn Anahita. ai[0] is her health + 2
                    Projectile.NewProjectile(new Terraria.DataStructures.EntitySource_WorldEvent(), player.position.X + player.width / 2 - 20, player.position.Y + player.height / 2 - 40,
                        0f, 0f, ModContent.ProjectileType<Projectiles.Boi.Anahita>(), 0, 0f, player.whoAmI, 7);
                    //Spawn the enemies
                    Projectile.NewProjectile(new Terraria.DataStructures.EntitySource_WorldEvent(), player.position.X + player.width / 2 - 280, player.position.Y + player.height / 2 - 40,
                        0f, 0f, ModContent.ProjectileType<Projectiles.Boi.Brimhita>(), 0, 0f, player.whoAmI, 0, 0);
                    Projectile.NewProjectile(new Terraria.DataStructures.EntitySource_WorldEvent(), player.position.X + player.width / 2 + 240, player.position.Y + player.height / 2 - 40,
                        0f, 0f, ModContent.ProjectileType<Projectiles.Boi.Brimhita>(), 0, 0f, player.whoAmI, 1, 1);

                    Projectile.NewProjectile(new Terraria.DataStructures.EntitySource_WorldEvent(), player.position.X + player.width / 2, player.position.Y + player.height / 2 - 80,
                        0f, 0f, ModContent.ProjectileType<Projectiles.Boi.Brimhita>(), 0, 0f, player.whoAmI, 2, 2);
                    spawnana = true;
                }
                //Spawns the room gates
                if (!spawnstuff)
                {
                    SpawnGates();
                    spawnstuff = true;
                }
                //A cooldown for entering new rooms to prevent infinite room teleporation
                roomcool--;
                //Detection for if Anahita is touching a room transition area
                for (int i = 0; i < Main.maxProjectiles; i++)
                {
                    var proj = Main.projectile[i];

                    if (proj.type == ModContent.ProjectileType<RoomTransition>())
                    {
                        for (int j = 0; j < Main.maxProjectiles; j++)
                        {
                            var proj2 = Main.projectile[j];
                            if (proj2 != null && proj2.active && proj2.getRect().Intersects(proj.getRect()) && proj2.type == ModContent.ProjectileType<Anahita>() && roomcool <= 0)
                            {
                                //The UI's ai is set to whatever the room transition's ai[0] is. This ai state is what room the UI is in
                                Projectile.localAI[0] = (int)proj.ai[0];
                                roomcool = 60;
                                //Clear room transition and tears
                                ClearStuff();
                                //Spawn new gates
                                SpawnStuff(proj2);
                            }
                        }
                    }
                }
            }
        }
        //Spawn gates based on the room
        void SpawnStuff(Projectile ana)
        {
            Player player = Main.player[Projectile.owner];
            //Spawn gates on all four sides in the starting room
            if (Projectile.localAI[0] == 0)
            {
                SpawnGates();
                ana.position = new Vector2(player.position.X + player.width / 2 - 10, player.position.Y + player.height / 2 - 215);
            }
            //Spawn just one gate leading to the starting room on the bottom
            if (Projectile.localAI[0] > 0)
            {
                Projectile.NewProjectile(new Terraria.DataStructures.EntitySource_WorldEvent(), player.position.X + player.width / 2 + 30, player.position.Y + player.height / 2 + 260,
                    0f, 0f, ModContent.ProjectileType<Projectiles.Boi.RoomTransition>(), 0, 0f, player.whoAmI, 0);
                ana.position = new Vector2(player.position.X + player.width / 2 - 10, player.position.Y + player.height / 2 + 100);
            }
        }

        //Spawns gates on all four sides that lead to the main four rooms
        void SpawnGates()
        {
            Player player = Main.player[Projectile.owner];
            CalValEXPlayer modPlayer = player.GetModPlayer<CalValEXPlayer>();
            //Bottom
            /*Projectile.NewProjectile(new Terraria.DataStructures.EntitySource_WorldEvent(), player.position.X + player.width / 2 + 10, player.position.Y + player.height / 2 + 260,
                0f, 0f, ModContent.ProjectileType<Projectiles.Boi.RoomTransition>(), 0, 0f, player.whoAmI, 3);
            //Left
            Projectile.NewProjectile(new Terraria.DataStructures.EntitySource_WorldEvent(), player.position.X + player.width / 2 - 430, player.position.Y + player.height / 2 - 20,
                0f, 0f, ModContent.ProjectileType<Projectiles.Boi.RoomTransition>(), 0, 0f, player.whoAmI, 2);*/
            //Top
            Projectile.NewProjectile(new Terraria.DataStructures.EntitySource_WorldEvent(), player.position.X + player.width / 2 + 10, player.position.Y + player.height / 2 - 270,
                0f, 0f, ModContent.ProjectileType<Projectiles.Boi.RoomTransition>(), 0, 0f, player.whoAmI, 1);
            //Right
            /*Projectile.NewProjectile(new Terraria.DataStructures.EntitySource_WorldEvent(), player.position.X + player.width / 2 + 440, player.position.Y + player.height / 2 - 20,
                0f, 0f, ModContent.ProjectileType<Projectiles.Boi.RoomTransition>(), 0, 0f, player.whoAmI, 4);*/
        }

        //KILL all tears and room transitions
        void ClearStuff()
        {
            for (int i = 0; i < Main.maxProjectiles; i++)
            {
                var proj = Main.projectile[i];

                if (proj.type == ModContent.ProjectileType<RoomTransition>() || proj.type == ModContent.ProjectileType<AnahitaTear>())
                {
                    proj.active = false;
                }
            }
        }

        public override void PostDraw(Color lightColor)
        {
            Player player = Main.player[Projectile.owner];
            CalValEXPlayer modPlayer = player.GetModPlayer<CalValEXPlayer>();
            if (modPlayer.boiactive)
            {
                //BG
                Texture2D texture2 = ModContent.Request<Texture2D>("CalValEX/ExtraTextures/Pong/PongBG").Value;
                Rectangle rectangle2 = new Rectangle(0, texture2.Height / Main.projFrames[Projectile.type] * Projectile.frame, texture2.Width, texture2.Height / Main.projFrames[Projectile.type]);
                Vector2 position2 = Projectile.Center - Main.screenPosition;
                position2.X += DrawOffsetX;
                position2.Y += DrawOriginOffsetY;
                Main.EntitySpriteDraw(texture2, position2, rectangle2, Color.White, Projectile.rotation, Projectile.Size / 2f, 1f, (Projectile.direction == 1 ? SpriteEffects.None : SpriteEffects.FlipHorizontally), 0);

                //Room
                Texture2D texture = ModContent.Request<Texture2D>("CalValEX/ExtraTextures/Boi/FourRoom").Value;
                Vector2 position = Projectile.Center - Main.screenPosition;
                position.X += DrawOffsetX;
                position.Y += DrawOriginOffsetY;
                Main.EntitySpriteDraw(texture, position, rectangle2, Color.White, Projectile.rotation, Projectile.Size / 2f, 1f, (Projectile.direction == 1 ? SpriteEffects.None : SpriteEffects.FlipHorizontally), 0);

                //Healthbar
                for (int i = 0; i < Main.maxProjectiles; i++)
                {
                    var proj = Main.projectile[i];

                    if (proj != null && proj.active && proj.type == ModContent.ProjectileType<Anahita>())
                    {
                        Texture2D mapicon = ModContent.Request<Texture2D>("CalValEX/ExtraTextures/Boi/Heart").Value;
                        Rectangle rectangle3 = new Rectangle(0, mapicon.Height / Main.projFrames[Projectile.type] * Projectile.frame, mapicon.Width, mapicon.Height / Main.projFrames[Projectile.type]);
                        Vector2 position3 = Projectile.Center - Main.screenPosition;
                        position3.X = position3.X + DrawOffsetX + 50;
                        position3.Y = position3.Y + DrawOriginOffsetY + 40;
                        for (int cont = 0; cont < proj.ai[0] - 1; cont++)
                        {
                            Main.EntitySpriteDraw(mapicon, new Vector2(position3.X + mapicon.Width * cont, position3.Y), rectangle3, Color.White, Projectile.rotation, Projectile.Size / 2f, 1f, (Projectile.direction == 1 ? SpriteEffects.None : SpriteEffects.FlipHorizontally), 0);
                        }
                    }
                }
                //Map
                {
                    Texture2D mapicon = ModContent.Request<Texture2D>("CalValEX/ExtraTextures/Pong/PongBall").Value;
                    Rectangle rectangle3 = new Rectangle(0, mapicon.Height / Main.projFrames[Projectile.type] * Projectile.frame, mapicon.Width, mapicon.Height / Main.projFrames[Projectile.type]);
                    Vector2 position3 = Projectile.Center - Main.screenPosition;
                    position3.X = position3.X + DrawOffsetX - 140;
                    position3.Y = position3.Y + DrawOriginOffsetY - 20;
                    for (int cont = 0; cont < 5; cont++)
                    {
                        Color cooo = cont == Projectile.localAI[0] ? Color.DarkCyan : Color.White;
                        Main.EntitySpriteDraw(mapicon, new Vector2(position3.X + mapicon.Width * cont, position3.Y), rectangle3, cooo, Projectile.rotation, Projectile.Size / 4f, 1f, (Projectile.direction == 1 ? SpriteEffects.None : SpriteEffects.FlipHorizontally), 0);
                    }
                }
            }
        }
    }
}