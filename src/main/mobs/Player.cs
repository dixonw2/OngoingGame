using System;
namespace OngoingGame {
    public class Player : Mob {

        byte level;
        short exp;
        public Player(string name) : base(name, 10, 5, 250) {
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

        public bool WinFight(Hostile enemy) {
            while (this.Health > 0 && enemy.Health > 0) {
                Random rand = new Random();
                bool crit = false;
                short playerAttack = (short) (rand.Next(this.Attack / 2, (byte) (this.Attack * 1.5)));

                // basic player attack exponentiation
                playerAttack = (short) ((Math.Pow(playerAttack, 3) / 3) - 15);

                // critical hit, 1/6 chance
                if (rand.Next(1, 7) == 2) {
                    crit = true;
                    playerAttack *= 2;
                }

                enemy.Health -= (short) (playerAttack - enemy.Defense);
                if ((short) (playerAttack - enemy.Defense) < 0)
                        Console.WriteLine($"{enemy.Name} healed {this.Name} for {Math.Abs((playerAttack - enemy.Defense))} health.");
                    else
                    Console.WriteLine($"{this.Name} did {(playerAttack - enemy.Defense)} damage to {enemy.Name}.");

                if (enemy.Health == 0)
                    break;
                
                if (!crit) {
                    short enemyAttack = (short) (rand.Next(enemy.Attack / 2, (byte) (enemy.Attack * 1.5)));
                    enemyAttack = (short) ((Math.Pow(enemyAttack, 3) / 20) - 10);
                    this.Health -= (short) (enemyAttack - this.Defense);
                    if ((short) (enemyAttack - this.Defense) < 0)
                        Console.WriteLine($"{enemy.Name} healed {this.Name} for {Math.Abs((enemyAttack - this.Defense))} health.");
                    else
                    Console.WriteLine($"{enemy.Name} did {(enemyAttack - this.Defense)} damage to {this.Name}.");
                }
                else
                    Console.WriteLine($"Critical Hit! {enemy.Name} was stunned.");

            }
            if (this.Health > 0)
                return true;
            return false;
        }

    }
}