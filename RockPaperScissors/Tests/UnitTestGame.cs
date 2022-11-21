using RockPaperScissors;

namespace Tests;

public class UnitTestGame
{
    private Game game = new Game();

    [Fact]
    public void TestGenerateComputerHand()
    {
        string[] possibleHands = { "rock", "paper", "scissors" };
        List<string> generatedHands = new List<string>();
        for (int i = 0; i < 100; i++)
        {
            string hand = game.GenerateComputerHand();
            Assert.Contains(possibleHands, item => item == hand);
            generatedHands.Add(hand);
        }

        foreach (string hand in possibleHands)
        {
            Assert.Contains(generatedHands, item => item == hand);
        }
    }

    [Fact]
    public void TestIsValidHand()
    {
        Assert.True(game.IsValidHand("rock"));
        Assert.True(game.IsValidHand("paper"));
        Assert.True(game.IsValidHand("scissors"));

        Assert.False(game.IsValidHand("blad"));
        Assert.False(game.IsValidHand("steen"));
        Assert.False(game.IsValidHand("schaar"));
        Assert.False(game.IsValidHand(""));
        Assert.False(game.IsValidHand(" "));
        Assert.False(game.IsValidHand("none"));
    }

    [Fact]
    public void TestDidPlayerWin()
    {
        Assert.False(game.DidPlayerWin("rock", "rock"));
        Assert.False(game.DidPlayerWin("paper", "paper"));
        Assert.False(game.DidPlayerWin("scissors", "scissors"));

        Assert.True(game.DidPlayerWin("paper", "rock"));
        Assert.True(game.DidPlayerWin("scissors", "paper"));
        Assert.True(game.DidPlayerWin("rock", "scissors"));

        Assert.False(game.DidPlayerWin("rock", "paper"));
        Assert.False(game.DidPlayerWin("paper", "scissors"));
        Assert.False(game.DidPlayerWin("scissors", "rock"));
    }
}