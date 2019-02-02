using System;

namespace OngoingGame {
    public class Storm : Hostile {
        private const string name = "Ice Storm";
        public Storm(Player player) : base(name, player) {

        }
    }
}