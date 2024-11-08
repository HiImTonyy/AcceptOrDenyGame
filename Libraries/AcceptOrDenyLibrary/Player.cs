namespace AcceptOrDenyLibrary
{
    public class Player
    {
        private string firstName;
        private string lastName;
        private double money;
        private int daysEmployed;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public double Money
        {
            get { return money; }
            set { money = value; }
        }

        public int DaysEmployed
        {
            get { return daysEmployed; }
            set { daysEmployed = value; }
        }

        public Player()
        {
            firstName = "Josie"; // #1!
            lastName = "Martinez";
            money = 0;
            daysEmployed = 0;
        }

        public static string NamePlayer(string description)
        {
            Console.Clear();
            string name = "timothy";

            Console.WriteLine(description);
            Console.Write("Input: ");
            name = Console.ReadLine();
            return name;
        }

        public static void Home(Bills bill, Player player, Work work)
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("HOME");
                Console.WriteLine("-----");
                Console.WriteLine("1) Go back to work");
                Console.WriteLine("2) Show Stats");
                Console.WriteLine("3) Save Game");
                Console.WriteLine("4) Game Info");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Work.Working(bill, player, work);
                        Console.ResetColor();
                        break;
                    case "2":
                        PlayerStats(bill, player, work);
                        break;
                    case "3":
                        Logic.SaveGame(bill, player, work);
                        break;
                    case "4":
                        Logic.GameInfo(bill, player, work);
                        break;
                }
            }
        }

        public static void PlayerStats(Bills bill, Player player, Work work)
        {
            Console.Clear();
            Console.WriteLine("STATS");
            Console.WriteLine("-----");
            Console.WriteLine($"Name: {player.FirstName} {player.LastName}");
            Console.WriteLine($"Current Balance {player.Money}");
            Console.WriteLine($"Current Daily Wage: {work.DayWage}");
            Console.WriteLine($"Total Correct Judgements: {work.AlltimeCorrectJudgements}");
            Console.WriteLine($"Total Incorrect Judgements: {work.AlltimeIncorrectJudgements}");
            Console.WriteLine($"Days Employed: {player.DaysEmployed}");
            Console.WriteLine($"Food Bill: {bill.FoodCost}");
            Console.WriteLine($"Elctric Bill: {bill.ElectricityCost}");
            Console.WriteLine($"Rent Bill: {bill.RentCost}\n");

            Console.WriteLine("Press Enter to go back...");
            Console.ReadLine();
        }
    }
}
