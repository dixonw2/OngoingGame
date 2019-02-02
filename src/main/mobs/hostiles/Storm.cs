using System;

namespace OngoingGame {
    public class Storm : Hostile {
        private const string name = "Ice Storm";
        public Storm(Player player) : base(name, player, (byte) (player.Attack * 1.2), (byte) (player.Defense / 2), (short) (player.Health * .7), 400) {
        }
    }
}