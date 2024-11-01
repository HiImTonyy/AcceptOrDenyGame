namespace AcceptOrDenyGame
{
    internal class Program
    {
        static void Main()
        {
            Console.WindowHeight = 45;
            Console.WindowWidth = 145;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("ACCEPT OR DENY - A text-based game by Anthony Butler\n");
            Console.ResetColor();

            Console.WriteLine("1) New Game");
            Console.WriteLine("2) Load Game");

            string input = Console.ReadLine();
        }
    }
}
