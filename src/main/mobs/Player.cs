using System;
namespace OngoingGame {
    public class Player : Mob {

        byte level;
        short exp;
        public Player(string name) : base(name, 5, 5, 250) {
            level = 1;
        }

        public byte Level {
            get {
                return level;
            }
            set {
                if (value > 100)
                    level = 100;
                else
                    level = value;
            }
        }
        public short Exp => exp;

        public void Fight(Hostile enemy) {
            while (this.Health > 0 && enemy.Health > 0) {

            }
        }

    }
}