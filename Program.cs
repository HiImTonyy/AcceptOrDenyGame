using AcceptOrDenyLibrary;

namespace AcceptOrDenyGame
{
    public class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WindowHeight = 45;
                Console.WindowWidth = 95;
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("ACCEPT OR DENY - A text-based game by Anthony Butler\n");
                Console.ResetColor();

                Console.WriteLine("1) New Game");
                Console.WriteLine("2) Load Game");


                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Player player = new Player();
                        Work work = new Work();

                        player.FirstName = Player.NamePlayer("Write the first name of your new character.");
                        player.LastName = Player.NamePlayer("And the last name?");
                        Console.Clear();
                        Work.Working(work, player);
                        break;
                }
            }
        }
    }
}