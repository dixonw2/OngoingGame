using System;

namespace OngoingGame {
    public abstract class Humanoid : Mob {
        private byte attack, defense;
        private short health;
        
        public Humanoid(string name, Player player) : base(name) {
            attack = (byte) (player.Attack * .8);
            health = 200;
        }

        public Humanoid(string name, byte attack, byte defense, short health) : base(name) {
            this.attack = attack;
            this.defense = defense;
            this.health = health;
        }

        public byte Attack {
            get { 
                return attack; 
            }
        }

        public byte Defense {
            get {
                return defense;
            }
        }

    }
}