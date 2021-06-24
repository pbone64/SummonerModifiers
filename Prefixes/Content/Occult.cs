namespace SummonerModifiers.Prefixes.Content
{
    // Equivelent to: Masterful
    public class Occult : SummonerPrefix
    {
        public override float Value => .62f;

        public override float DamageMult => 1.16f;
        public override float KnockbackMult => 1.05f;
        public override float UseTimeMult => 1f;
        public override float ManaMult => 0.85f;
    }
}
