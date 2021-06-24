namespace SummonerModifiers.Prefixes.Content
{
    // Equivelent to: Deranged
    public class Heretical : SummonerPrefix
    {
        public override float Value => 1f - 0.3174f;

        public override float DamageMult => 0.9f;
        public override float KnockbackMult => 0.9f;
        public override float UseTimeMult => 1f;
        public override float ManaMult => 1f;

        public override bool Bad => true;
    }
}
