using SummonerModifiers.Prefixes.Content;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;
using static Terraria.ModLoader.ModContent;

namespace SummonerModifiers.Items
{
    public class PrefixGlobalItem : GlobalItem
    {
        public override int ChoosePrefix(Item item, UnifiedRandom rand)
        {
            if (!item.summon || item.damage < 1)
                return base.ChoosePrefix(item, rand);

            // It looks like vanilla has an equal change for each prefix
            // For reference, there's 36 vanilla prefixes
            // Universal (14) + Common (10) + Magic (12)
            WeightedRandom<int> random = new WeightedRandom<int>(rand);

            // Universal Prefixes (14)
            random.Add(PrefixID.Keen);
            random.Add(PrefixID.Superior);
            random.Add(PrefixID.Forceful);
            random.Add(PrefixID.Broken);
            random.Add(PrefixID.Damaged);
            random.Add(PrefixID.Shoddy);
            random.Add(PrefixID.Hurtful);

            random.Add(PrefixID.Strong);
            random.Add(PrefixID.Unpleasant);
            random.Add(PrefixID.Weak);
            random.Add(PrefixID.Ruthless);
            random.Add(PrefixID.Godly);
            random.Add(PrefixID.Demonic);
            random.Add(PrefixID.Zealous);

            // Common (10)
            random.Add(PrefixID.Quick);
            random.Add(PrefixID.Deadly);
            random.Add(PrefixID.Agile);
            random.Add(PrefixID.Nimble);
            random.Add(PrefixID.Murderous);

            random.Add(PrefixID.Slow);
            random.Add(PrefixID.Sluggish);
            random.Add(PrefixID.Lazy);
            random.Add(PrefixID.Annoying);
            random.Add(PrefixID.Nasty);

            // Summon (12)
            random.Add(PrefixType<Corporeal>());
            random.Add(PrefixType<Enigmatic>());
            random.Add(PrefixType<Ethereal>());
            random.Add(PrefixType<Glowing>());
            random.Add(PrefixType<Heretical>());
            random.Add(PrefixType<Insane>());

            random.Add(PrefixType<Inscribed>());
            random.Add(PrefixType<Occult>());
            random.Add(PrefixType<Otherwordly>());
            random.Add(PrefixType<Overcharged>());
            random.Add(PrefixType<Pale>());
            random.Add(PrefixType<Potent>());

            return random.Get();
        }
    }
}
