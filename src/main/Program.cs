using System;
namespace OngoingGame {
    class Program {
        static void Main(string[] args) {

            Humanoid player = new Player("Wyatt");
            Console.WriteLine($"Attack: {player.Attack}");
        }
    }
}