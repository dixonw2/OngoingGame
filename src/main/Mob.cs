using System;

namespace OngoingGame {
    public abstract class Mob {
        private string name;
        private byte exp;
        public Mob(string name, Player player) {
            this.name = name;
        }
    }
}