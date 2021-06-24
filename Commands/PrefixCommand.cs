using Terraria;
using Terraria.ModLoader;

namespace SummonerModifiers.Commands
{
    public class PrefixCommand : ModCommand
    {
        public override bool Autoload(ref string name) => true;

        public override string Command => "pre";

        public override CommandType Type => CommandType.Chat;

        public override void Action(CommandCaller caller, string input, string[] args)
        {
            Player player = caller.Player;

            player.HeldItem.SetDefaults(player.HeldItem.type);
            player.HeldItem.Prefix(mod.PrefixType(args[0]));
        }
    }
}
