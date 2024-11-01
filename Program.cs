using AcceptOrDenyLibrary;

namespace AcceptOrDenyGame
{
    public class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.WindowHeight = 45;
            Console.WindowWidth = 145;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("ACCEPT OR DENY - A text-based game by Anthony Butler\n");
            Console.ResetColor();

            Console.WriteLine("1) New Game");
            Console.WriteLine("2) Load Game");
        

            string input = Console.ReadLine();
            Player player = new Player();

            switch (input)
            {
                case "1":
                   player.FirstName = Player.NamePlayer("Write the first name of your new character.");
                   player.LastName = Player.NamePlayer("And the last name?");
                    break;
            }
        }
    }
}
