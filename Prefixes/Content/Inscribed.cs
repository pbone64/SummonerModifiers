namespace SummonerModifiers.Prefixes.Content
{
    // Equivelent to: Celestial
    public class Inscribed : SummonerPrefix
    {
        public override float Value => .4929f;

        public override float DamageMult => 1.11f;
        public override float KnockbackMult => 1.1f;
        public override float UseTimeMult => 1.1f;
        public override float ManaMult => 0.9f;
    }
}
