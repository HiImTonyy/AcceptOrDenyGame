using AcceptOrDenyLibrary;

namespace AcceptOrDenyGame
{
    public class Program
    {
        static void Main()
        {
            while (true)
            {
                Bills bill = new Bills();
                Player player = new Player();
                Work work = new Work();

                Console.Clear();
                Console.WindowHeight = 45;
                Console.WindowWidth = 105;
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("ACCEPT OR DENY - A text-based game by Anthony Butler\n");
                Console.ResetColor();

                Console.WriteLine("1) New Game");
                Console.WriteLine("2) Load Game");
                Console.WriteLine("3) Game Info");


                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Logic.NewGame(bill, player, work);
                        break;
                    case "2":
                        Logic.LoadGame(bill, player, work);
                        break;
                    case "3":
                        Logic.GameInfo(bill, player, work);
                        break;
                }
            }
        }
    }
}