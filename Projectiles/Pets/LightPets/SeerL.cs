using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;

namespace CalValEX.Projectiles.Pets.LightPets
{
    public class SeerL : FlyingPet
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Small Sightseer");
            Main.projFrames[Projectile.type] = 5;
            Main.projPet[Projectile.type] = true;
            ProjectileID.Sets.LightPet[Projectile.type] = true;
        }

        public override void SafeSetDefaults()
        {
            Projectile.width = 62;
            Projectile.height = 30;
            Projectile.ignoreWater = true;
            facingLeft = true;
            spinRotation = false;
            shouldFlip = true;
            usesAura = false;
            usesGlowmask = true;
            auraUsesGlowmask = false;
        }

        public override void SetUpFlyingPet()
        {
            distance[0] = 1840f;
            distance[1] = 560f;
            speed = 10f;
            inertia = 60f;
            animationSpeed = 4;
            spinRotationSpeedMult = 0f;
            offSetX = -21f * -Main.player[Projectile.owner].direction;
            offSetY = -11f;
        }
        public override void SetUpAuraAndGlowmask()
        {
            glowmaskTexture = CalValEX.month == 12 ? "CalValEX/ExtraTextures/ChristmasPets/SeerLGlow" : "CalValEX/Projectiles/Pets/LightPets/SeerL_Glow";
        }

        public override void SetUpLight() //for when the pet emmits light
        {
            shouldLightUp = true;
            RGB = new Vector3(255, 71, 66);
            intensity = 0.9f;
            abyssLightLevel = 2;
        }

        public override void SafeAI(Player player)
        {
            CalValEXPlayer modPlayer = player.GetModPlayer<CalValEXPlayer>();

            if (player.dead)
                modPlayer.seerL = false;
            if (modPlayer.seerL)
                Projectile.timeLeft = 2;

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