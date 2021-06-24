namespace SummonerModifiers.Prefixes.Content
{
    // Equivelent to: Mythical
    public class Ethereal : SummonerPrefix
    {
        public override float Value => 1.1985f;

        public override float DamageMult => 1.2f;
        public override float KnockbackMult => 1.15f;
        public override float UseTimeMult => 0.9f;
        public override float ManaMult => 0.9f;
    }
}
