namespace SummonerModifiers.Prefixes.Content
{
    // Equivelent to: Ignorant
    public class Corporeal : SummonerPrefix
    {
        public override float Value => 1f - 0.4607f;

        public override float DamageMult => 0.9f;
        public override float KnockbackMult => 1.15f;
        public override float UseTimeMult => 1f;
        public override float ManaMult => 1.2f;

        public override bool Bad => true;
    }
}
