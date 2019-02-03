using System;

namespace OngoingGame {
    public abstract class Mob {
        private string name;
        private byte attack, defense;
        private short maxHealth, curHealth;

        public Mob(string name) : this(name, 0, 0, 100) {
        }
        public Mob(string name, byte attack, byte defense, short health) {
            this.name = name;
            this.attack = attack;
            this.defense = defense;
            this.maxHealth = health;
            this.curHealth = maxHealth;
        }

        public byte Attack {
            get { 
                return attack; 
            }
            set {
                if (value > 255)
                    attack = 255;
                else
                    attack = value;
            }
        }
        public byte Defense {
            get {
                return defense;
            }
            set {
                if (value > 255)
                    defense = 255;
                else
                    defense = value;
            }
        }
        public string Name => name;
        public short Health {
            get {
                return curHealth;
            }
            set {
                if (value > maxHealth)
                    curHealth = maxHealth;
                else if (value < 0)
                    curHealth = 0;
                else
                    curHealth = value;
            }
        }

        public short MaxHealth {
            get {
                return maxHealth;
            }
            set {
                if (value > 9999)
                    maxHealth = 9999;
                else if (value < 0)
                    maxHealth = 0;
                else
                    maxHealth = value;
            }
        }
    }
}