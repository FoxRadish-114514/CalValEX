﻿using Terraria;
//using CalamityMod.Particles;
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CalValEX.Projectiles.Pets
{
    public class MiniCryo : FlyingPet
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chill Dude");
            //Main.projFrames[Projectile.type] = 4; //frames
            Main.projPet[Projectile.type] = true;
        }

        public override void SafeSetDefaults() //SafeSetDefaults!!!
        {
            Projectile.width = 20;
            Projectile.height = 24;
            Projectile.ignoreWater = true;
            /* you don't need to set these anymore!
            Projectile.penetrate = -1;
            Projectile.netImportant = true;
            Projectile.timeLeft *= 5;
            Projectile.friendly = true;
            Projectile.tileCollide = false;
            */
            facingLeft = false; //is the sprite facing left? if so, put this to true. if its facing to right keep it false.
            spinRotation = false; //should it spin? if that's the case, set to true. else, leave it false.
            shouldFlip = true; //should the sprite flip? set true if it should, false if it shouldnt
            usesAura = true; //does this pet use an aura?
            usesGlowmask = false; //does this pet use a glowmask?
            auraUsesGlowmask = false; //does the aura use a glowmask?
        }

        public override void SetUpFlyingPet()
        {
            distance[0] = 1840f; //teleport distance
            distance[1] = 560f; //faster speed distance
            speed = 12f;
            inertia = 60f;
            animationSpeed = 30; //how fast the animation should play
            spinRotationSpeedMult = 0.2f; //rotation speed multiplier, keep it positive for it to spin in the right direction
            offSetX = 48f * -Main.player[Projectile.owner].direction; //this is needed so it's always behind the player.
            offSetY = -50f; //how much higher from the center the pet should float
        }

        //you usualy don't have to use the lower two unless you want the pet to have an aura, glowmask
        //or if you want the pet to emit light

        public override void SetUpAuraAndGlowmask() //for aura and glowmasks
        {
            auraTexture = "CalValEX/Projectiles/Pets/MiniCryoShield"; //aura texture location
            auraRotates = true; //does the aura rotate?
            auraRotation = true; //where does the aura rotate? true for right, false for left
            auraRotationSpeedMult = 0.05f; //aura rotation multiplier

            glowmaskTexture = ""; //glowmask texture location
            auraGlowmaskTexture = ""; //aura glowmask texture location
        }

        public override void SafeAI(Player player)
        {
            CalValEXPlayer modPlayer = player.GetModPlayer<CalValEXPlayer>();

            if (player.dead)
                modPlayer.MiniCryo = false;
            if (modPlayer.MiniCryo)
                Projectile.timeLeft = 2;


            Vector2 vectorToOwner = player.Center - Projectile.Center;
            float distanceToOwner = vectorToOwner.Length();
            Vector2 placementrun = new Vector2(Projectile.Center.X + Main.rand.Next(-5, 5), Projectile.Center.Y + Main.rand.Next(-6, 6));
            /*if ((Math.Abs(Projectile.velocity.X) > 5 || Math.Abs(Projectile.velocity.Y) > 5) && Main.rand.Next(2) == 0)
            {
                Particle mist = new MediumMistParticle(placementrun, Vector2.Zero, new Color(172, 238, 255), new Color(145, 170, 188), Main.rand.NextFloat(0.15f, 0.45f), 245 - Main.rand.Next(50), 0.02f);
                mist.Velocity = (mist.Position - Projectile.Center) * 0.2f + Projectile.velocity;
                GeneralParticleHandler.SpawnParticle(mist);
            }*/
            /* THIS CODE ONLY RUNS AFTER THE MAIN CODE RAN.
             * for custom behaviour, you can check if the projectile is walking or not via Projectile.localAI[1]
             * you should make new custom behaviour with numbers higher than 0, or less than 0
             * the next few lines is an example on how to implement this
             *
             * switch ((int)Projectile.localAI[1])
             * {
             *     case -1:
             *         break;
             *     case 1:
             *         break;
             * }
             *
             * 0 is already in use.
             * 0 = flying
             *
             * you can still use this, changing thing inside (however it's not recomended unless you want to add custom behaviour to this)
             */
        }
    }
}