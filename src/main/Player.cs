using System;
namespace OngoingGame {
    public class Player : Mob {

        byte level;
        short exp;
        public Player(string name) : base(name, 5, 5, 200) {
            level = 1;
        }

        public byte Level => level;
        public short Exp => exp;

    }
}