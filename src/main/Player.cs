using System;
namespace OngoingGame {
    public class Player : Humanoid {
        private double exp;
        public Player(string name) : base(name, 10, 10, 300) {
            this.exp = 0;
        }

    }
}