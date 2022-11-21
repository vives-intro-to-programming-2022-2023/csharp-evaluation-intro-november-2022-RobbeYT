using System.Threading.Tasks;

namespace LabradorGoesWoof;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Labrador Goes Woof");
        Console.WriteLine("\nLet's see how many times your dog barked today:\n");

        BarkCounter counter = new BarkCounter();

        Console.WriteLine($"8h-9h: { counter.CountBarks("xxxxxxxxxxBxxxxxxBBBxxxxxBxxBxxxxxBxxxxxBxxxxxxBxxxxxxxxxxxB") } time(s)");
        Console.WriteLine($"10h-11h: { counter.CountBarks("xxxBBBxxxxxBBBBBxBxBxBxxxxBBxBxBBBBBxxxBBBxBBBxBBxxxxxxxxxxx") } time(s)");
        Console.WriteLine($"11h-12h: {counter.CountBarks("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx") } time(s)");
        Console.WriteLine($"12h-13h: { counter.CountBarks("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx") } time(s)");
        Console.WriteLine($"14h-15h: { counter.CountBarks("BBxBBxBBxBBxBBBBBBxxxxxBBBBBBxBBBBBxxxxxxxxxxBBBBxxxxxxxBBBB") } time(s)");
        Console.WriteLine($"16h-17h: { counter.CountBarks("xxxxxxxxxxxxxxxxxxxxxxxxxBxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx") } time(s)");

        Console.WriteLine("\nThank you for using Labrador Goes Woof");
    }
}
