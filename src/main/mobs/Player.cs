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

        public bool Fight(Hostile enemy) {
            while (this.Health > 0 && enemy.Health > 0) {
                Random rand = new Random();
                bool crit = false;

                // damage calc
                short playerAttack = (short) ((Math.Pow(this.Attack, 2) / 8) + 20);
                float multiplier = (float) (rand.Next(8, 13) / 10.0);
                multiplier *= playerAttack;
                playerAttack = (short) (multiplier);

                // critical hit, 1/6 chance
                if (rand.Next(1, 7) == 2) {
                    crit = true;
                    playerAttack *= 2;
                }

                enemy.Health -= (short) (playerAttack - enemy.Defense);
                printFight(this, enemy, (short) (playerAttack - enemy.Defense), crit);

                if (enemy.Health == 0)
                    break;
                
                if (!crit) {

                    // damage calc
                    short enemyAttack = (short) ((Math.Pow(enemy.Attack, 2) / 8) + 20);
                    multiplier = (float) (rand.Next(8, 13) / 10.0);
                    multiplier *= enemyAttack;
                    enemyAttack = (short) (multiplier);

                    this.Health -= (short) (enemyAttack - this.Defense);
                    printFight(enemy, this, (short) (enemyAttack - this.Defense), false);
                }

                System.Threading.Thread.Sleep(1000);

            }
            if (this.Health > 0)
                return true;
            return false;
        }

        private void printFight(Mob attacker, Mob attacked, short damage, bool crit) {
            if (crit) {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(attacker.Name);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" landed a critical hit on ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(attacked.Name);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" for ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{damage} damage! ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(attacked.Name);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" was stunned.");
            }
            else {
                if (attacker is Player) {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(attacker.Name);
                    Console.ForegroundColor = ConsoleColor.White;
                    if (damage >= 0) {
                        Console.Write(" did ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"{damage} damage ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("to ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(attacked.Name);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(".");
                    }
                    else {
                        Console.Write(" healed ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(attacked.Name);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" for ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"{Math.Abs(damage)} health");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(".");
                    }
                }
                else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(attacker.Name);
                    Console.ForegroundColor = ConsoleColor.White;
                    if (damage >= 0) {
                        Console.Write(" did ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"{damage} damage ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("to ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(attacked.Name);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(".");
                    }
                    else {
                        Console.Write(" healed ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(attacked.Name);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" for ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"{Math.Abs(damage)} health");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(".");
                    }
                }
            }
        }

    }
}