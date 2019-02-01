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

        public byte Attack => attack;
        public byte Defense => defense;
        public string Name => name;
        public short Health => health;
    }
}