using System;
namespace OngoingGame {
    public class Program {
        static void Main(string[] args) {

            Humanoid player = new Player("Wyatt");
            Console.WriteLine($"Attack: {player.Attack}");
        }
    }
}