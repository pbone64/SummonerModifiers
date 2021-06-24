using Terraria;
using Terraria.ModLoader;

namespace SummonerModifiers.Prefixes
{
    public abstract class SummonerPrefix : ModPrefix
    {
        public abstract float Value { get; }

        public abstract float DamageMult { get; }
        public abstract float KnockbackMult { get; }
        public abstract float UseTimeMult { get; }
        public abstract float ManaMult { get; }

        public virtual bool Bad { get => false; }

        // I'm assinging them manually in PrefixGlobalItem, they shouldn't be part of the prefix pool
        public override float RollChance(Item item) => 0f;
        public override bool CanRoll(Item item) => false;
        public override PrefixCategory Category => PrefixCategory.Custom;

        public SummonerPrefix()
        {
        }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
        {
            damageMult *= DamageMult;
            knockbackMult *= KnockbackMult;
            useTimeMult *= UseTimeMult;
            manaMult *= ManaMult;
        }

        public override void ModifyValue(ref float valueMult)
        {
            float multiplier = Value;

            // Hacks to get the price to work
            if (!Bad)
                multiplier += 1f;

            if (multiplier > 1f) multiplier -= 0.5f;

            valueMult = multiplier;
        }
    }
}
