namespace SummonerModifiers.Prefixes.Content
{
    // Equivelent to: Adept
    public class Glowing : SummonerPrefix
    {
        public override float Value => .3759f;

        public override float DamageMult => 1f;
        public override float KnockbackMult => 1f;
        public override float UseTimeMult => 1f;
        public override float ManaMult => 0.85f;
    }
}
