using System;
namespace OngoingGame {
    public class Program {
        public static void Main(string[] args) {
            Console.WriteLine("What is your name?");
            string playerName = Console.ReadLine();
            Player player = new Player("playerName");
            Storm storm = new Storm(player);
            Console.WriteLine($"Attack: {player.Attack}");
        }
    }
}