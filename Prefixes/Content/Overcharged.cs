namespace SummonerModifiers.Prefixes.Content
{
    // Equivelent to: Taboo
    public class Overcharged : SummonerPrefix
    {
        public override float Value => .2338f;

        public override float DamageMult => 1f;
        public override float KnockbackMult => 1.1f;
        public override float UseTimeMult => 0.9f;
        public override float ManaMult => 1.1f;
    }
}
