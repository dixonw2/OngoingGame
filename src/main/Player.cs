using System;
namespace OngoingGame {
    public class Player : Humanoid {
        private double exp;
        public Player(string name) : base(name, null) {
            this.exp = 0;
        }

    }
}