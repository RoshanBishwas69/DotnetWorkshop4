namespace Task4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Player player1 = new Player();
        player1.playerName = "USA";
        player1.level = 100;
        player1.health = "very good";


        Player player2 = new Player("Canada", 10, "Good");
        Console.WriteLine($"Player 1: Name = {player1.playerName}, Level = {player1.level}, Health = {player1.health}");
        Console.WriteLine($"Player 2: Name = {player2.playerName}, Level = {player2.level}, Health = {player2.health}");

    }
}