namespace SummonerModifiers.Prefixes.Content
{
    // Equivelent to: Inept
    public class Pale : SummonerPrefix
    {
        public override float Value => 1f - 0.1573f;

        public override float DamageMult => 1f;
        public override float KnockbackMult => 1f;
        public override float UseTimeMult => 1f;
        public override float ManaMult => 1.1f;

        public override bool Bad => true;
    }
}
