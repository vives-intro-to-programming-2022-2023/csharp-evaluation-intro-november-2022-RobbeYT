namespace RockPaperScissors;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Rock / Paper / Scissors\n");

        Game game = new Game();

        string playerHand = "";
        do
        {
            Console.Write("Please choose your weapon [rock,paper,scissors]: ");
            playerHand = Console.ReadLine();
        } while (!game.IsValidHand(playerHand));

        string computerHand = game.GenerateComputerHand();

        Console.WriteLine($"\nYou chose {playerHand} while computer chose {computerHand}");

        if (game.DidPlayerWin(playerHand, computerHand))
        {
            Console.WriteLine("Congratz! You won !!!!!");
        }
        else
        {
            Console.WriteLine("Sorry to inform you, but you lost !");
        }

        Console.WriteLine("\nThanks for playing Rock / Paper / Scissors");
    }
}
