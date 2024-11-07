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
    }
}
