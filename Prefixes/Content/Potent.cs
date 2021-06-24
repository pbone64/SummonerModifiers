namespace SummonerModifiers.Prefixes.Content
{
    // Equivelent to: Intense
    public class Potent : SummonerPrefix
    {
        public override float Value => 1f - 0.095f;

        public override float DamageMult => 1.11f;
        public override float KnockbackMult => 1f;
        public override float UseTimeMult => 1f;
        public override float ManaMult => 1.15f;

        public override bool Bad => true;
    }
}
