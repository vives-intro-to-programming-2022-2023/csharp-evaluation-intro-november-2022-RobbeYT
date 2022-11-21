namespace RateMySetup;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Rate My Setup");

        Console.WriteLine("Let's rate some things\n");

        RatingGenerator rateGenerator = new RatingGenerator();

        Console.WriteLine($"Github Rating:   {rateGenerator.Rate(5, 5, '*')}");
        Console.WriteLine($"TikTok Rating:   {rateGenerator.Rate(0, 5, '*')}");
        Console.WriteLine($"LinkedIn Rating: {rateGenerator.Rate(4, 5, '!')}");
        Console.WriteLine($"C++ Rating:      {rateGenerator.Rate(9, 10, '+')}");
        Console.WriteLine($"Python Rating:   {rateGenerator.Rate(6, 10, '~')}");

        Console.WriteLine("\nThank you for using Rate My Setup");
    }
}