using System;
using System.Threading;

class Program
{
    static void Main()
    {
        DisplayObjectives();

        Console.Write("Enter your name: ");
        string playerName = Console.ReadLine();

        TempleAdventure game = new TempleAdventure(playerName);
        game.Start();
    }

    static void DisplayObjectives()
    {
        Console.WriteLine("|===================================================|");
        Console.WriteLine("|           ANCIENT TEMPLE ADVENTURE                |");
        Console.WriteLine("| Welcome to the Ancient Temple Adventure!          |");
        Console.WriteLine("| Your objective is to explore the temple, collect  |");
        Console.WriteLine("| treasures, and avoid traps. Be careful!           |");
        Console.WriteLine("| Good luck, adventurer!                            |");
        Console.WriteLine("|===================================================|");
        Console.WriteLine();
    }
}

class TempleAdventure
{
    private string playerName;
    private int treasures;
    private int trapsAvoided;
    private Random random;

    public TempleAdventure(string playerName)
    {
        this.playerName = playerName;
        treasures = 0;
        trapsAvoided = 0;
        random = new Random();
    }

    public void Start()
    {
        while (true)
        {
            Console.WriteLine($"\n{playerName}, you have found {treasures} treasures and successfully avoided {trapsAvoided} traps.");
            Console.WriteLine("Available actions:");
            Console.WriteLine("1. Explore the temple");
            Console.WriteLine("2. Check treasures");
            Console.WriteLine("3. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ExploreTemple();
                    break;
                case "2":
                    CheckTreasures();
                    break;
                case "3":
                    Console.WriteLine("Thank you for playing!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private void ExploreTemple()
    {
        int eventOutcome = random.Next(1, 5);
        switch (eventOutcome)
        {
            case 1:
                treasures++;
                Console.WriteLine("You found a treasure!");
                break;
            case 2:
                trapsAvoided++;
                Console.WriteLine("You successfully avoided a trap!");
                break;
            default:
                Console.WriteLine("You explored the temple, but found nothing.");
                break;
        }
    }

    private void CheckTreasures()
    {
        Console.WriteLine($"{playerName}, you have found {treasures} treasures.");
    }
}
