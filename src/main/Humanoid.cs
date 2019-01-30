using System;

namespace OngoingGame {
    public abstract class Humanoid {
        private string name;
        private byte attack, defense;
        private short health;
        
        public Humanoid(string name) {
            this.name = name;
            attack = 5;
        }

        public Humanoid(string name, byte attack, byte defense, short health) {
            this.name = name;
            this.attack = attack;
            this.defense = defense;
            this.health = health;
        }

        public byte Attack {
            get{ return attack; }
        }

    }
}