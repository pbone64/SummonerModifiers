namespace SummonerModifiers.Prefixes.Content
{
    // Equivelent to: Manic
    public class Insane : SummonerPrefix
    {
        public override float Value => .2338f;

        public override float DamageMult => 0.9f;
        public override float KnockbackMult => 1f;
        public override float UseTimeMult => 0.9f;
        public override float ManaMult => 0.9f;
    }
}
