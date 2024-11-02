namespace AcceptOrDenyLibrary
{
    public class Player
    {
        private string firstName;
        private string lastName;
        private int money;
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

        public int Money
        {
            get { return money; }
            set { money = value; }
        }

        private int DaysEmployed
        {
            get { return daysEmployed; }
            set { daysEmployed = value; }
        }

        public Player()
        {
            firstName = "Josie";
            lastName = "Wavos";
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
    }
}
