using System;

namespace OngoingGame {
    public abstract class Hostile : Mob {
        private Player player;
        private short exp;
        public Hostile(string name, Player player, byte attack, byte defense, short health, short exp) : base(name, attack, defense, health) {
            this.player = player;
            this.exp = exp;
        }

        public short Exp => exp;

    }
}