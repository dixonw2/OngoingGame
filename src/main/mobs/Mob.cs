using System;

namespace OngoingGame {
    public abstract class Mob {
        private string name;
        private byte attack, defense;
        private short health;

        public Mob(string name) : this(name, 0, 0, 100) {
        }
        public Mob(string name, byte attack, byte defense, short health) {
            this.name = name;
            this.attack = attack;
            this.defense = defense;
            this.health = health;
        }

        public byte Attack {
            get { 
                return attack; 
            }
            set {
                attack = value;
            }
        }
        public byte Defense {
            get {
                return defense;
            }
            set {
                defense = value;
            }
        }
        public string Name => name;
        public short Health {
            get {
                return health;
            }
            set {
                if (value > 9999)
                    health = 9999;
                else if (value < 0)
                    health = 0;
                else
                    health = value;
            }
        }
    }
}