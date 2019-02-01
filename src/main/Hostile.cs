using System;

namespace OngoingGame {
    public abstract class Hostile : Mob {
        private Player player;
        public Hostile(string name, Player player) : base(name) {
            this.player = player;
        }
    }
}