using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcceptOrDenyLibrary
{
    public class NPC
    {
        private string firstName;
        private string lastName;
        private int birthMonth;
        private int birthDay;
        private int birthYear;
        private int age;
        private string gender;
        private string streetAddress;
        private int streetNumber;
        private string streetDirection;
        private int expirationMonth;
        private int expirationDay;
        private int expirationYear;
        private bool isIllegal;
        private int errorType;

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

        public int BirthMonth
        {
            get { return birthMonth; }
            set { birthMonth = value; }
        }

        public int BirthDay
        {
            get { return birthDay; }
            set { birthDay = value; }
        }

        public int BirthYear
        {
            get { return birthYear; }
            set { birthYear = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string StreetAddress
        {
            get { return streetAddress; }
            set { streetAddress = value; }
        }

        public int StreetNumber
        {
            get { return streetNumber; }
            set { streetNumber = value; }
        }

        public string StreetDirection
        {
            get { return streetDirection; }
            set { streetDirection = value; }
        }

        public bool IsIllegal
        {
            get { return isIllegal; }
            set { isIllegal = value; }
        }
        public int ExpirationMonth
        {
            get { return expirationMonth; }
            set { expirationMonth = value; }
        }
        public int ExpirationDay
        {
            get { return expirationDay; }
            set { expirationDay = value; }
        }

        public int ExpirationYear
        {
            get { return expirationYear; }
            set { expirationYear = value; }
        }

        public int ErrorType
        {
            get { return errorType; }
            set { errorType = value; }
        }

        public NPC()
        {
            FirstName = this.FirstName;
            LastName = this.LastName;
            BirthMonth = this.BirthMonth;
            BirthDay = this.BirthDay;
            BirthYear = this.BirthYear;
            Age = this.Age;
            Gender = this.Gender;
            StreetAddress = this.StreetAddress;
            StreetNumber = this.StreetNumber;
            StreetDirection = this.StreetDirection;
            ExpirationMonth = this.ExpirationMonth;
            ExpirationDay = this.ExpirationDay;
            ExpirationYear = this.ExpirationYear;
        }

        public NPC(NPC npc)
        {
            FirstName = npc.FirstName;
            LastName = npc.LastName;
            BirthMonth = npc.BirthMonth;
            BirthDay = npc.BirthDay;
            BirthYear = npc.BirthYear;
            Age = npc.Age;
            Gender = npc.Gender;
            StreetAddress = npc.StreetAddress;
            StreetNumber = npc.StreetNumber;
            StreetDirection = npc.StreetDirection;
            ExpirationMonth = npc.ExpirationMonth;
            ExpirationDay = npc.ExpirationDay;
            ExpirationYear = npc.ExpirationYear;
        }

        public NPC GenerateNPC()
        {

            NPC npc = new NPC();

            List<string> maleNames = new List<string>();

            maleNames.Add("Anthony");
            maleNames.Add("Tommy");
            maleNames.Add("Johnny");
            maleNames.Add("Zach");
            maleNames.Add("Jacob");
            maleNames.Add("Robert");
            maleNames.Add("Charles");
            maleNames.Add("Glen");
            maleNames.Add("Austin");
            maleNames.Add("Cory");
            maleNames.Add("Leo");
            maleNames.Add("Noah");
            maleNames.Add("James");
            maleNames.Add("Theodore");
            maleNames.Add("Henry");
            maleNames.Add("Alan");
            maleNames.Add("Lucas");
            maleNames.Add("William");
            maleNames.Add("Jack");
            maleNames.Add("Michael");
            maleNames.Add("David");
            maleNames.Add("Jackson");
            maleNames.Add("Joey");
            maleNames.Add("Joseph");
            maleNames.Add("Mason");
            maleNames.Add("Matt");
            maleNames.Add("Matthew");
            maleNames.Add("Luke");
            maleNames.Add("Jacob");
            maleNames.Add("Connor");
            maleNames.Add("Jason");
            maleNames.Add("Miles");
            maleNames.Add("Wyatt");
            maleNames.Add("Wayne");
            maleNames.Add("Jayden");
            maleNames.Add("Caleb");
            maleNames.Add("Chris");
            maleNames.Add("Nathan");
            maleNames.Add("Daniel");
            maleNames.Add("Cameron");
            maleNames.Add("Nolan");
            maleNames.Add("Andrew");
            maleNames.Add("Ian");
            maleNames.Add("Christian");
            maleNames.Add("Johnathan");
            maleNames.Add("Jaxon");
            maleNames.Add("Everett");
            maleNames.Add("Colton");
            maleNames.Add("Dominic");
            maleNames.Add("Carson");

            List<string> femaleNames = new List<string>();

            femaleNames.Add("Cynthia");
            femaleNames.Add("Rose");
            femaleNames.Add("Samantha");
            femaleNames.Add("Laura");
            femaleNames.Add("Kasaundra");
            femaleNames.Add("Clara");
            femaleNames.Add("Aurora");
            femaleNames.Add("Nicole");
            femaleNames.Add("Tammy");
            femaleNames.Add("Francine");
            femaleNames.Add("Olivia");
            femaleNames.Add("Taylor");
            femaleNames.Add("Amelia");
            femaleNames.Add("Sophia");
            femaleNames.Add("Isabelle");
            femaleNames.Add("Luna");
            femaleNames.Add("Sophia");
            femaleNames.Add("Elizabeth");
            femaleNames.Add("Violet");
            femaleNames.Add("June");
            femaleNames.Add("Lilly");
            femaleNames.Add("Emily");
            femaleNames.Add("Nora");
            femaleNames.Add("Chloe");
            femaleNames.Add("Ellie");
            femaleNames.Add("Mia");
            femaleNames.Add("Avery");
            femaleNames.Add("Layla");
            femaleNames.Add("Elena");
            femaleNames.Add("Madison");
            femaleNames.Add("Zoey");
            femaleNames.Add("Lucy");
            femaleNames.Add("Emilia");
            femaleNames.Add("Grace");
            femaleNames.Add("Victoria");
            femaleNames.Add("Hannah");
            femaleNames.Add("Leah");
            femaleNames.Add("Lainey");
            femaleNames.Add("Madelyn");
            femaleNames.Add("Addison");
            femaleNames.Add("Natalie");
            femaleNames.Add("Alice");
            femaleNames.Add("Claire");
            femaleNames.Add("Ruby");
            femaleNames.Add("Eden");
            femaleNames.Add("Jade");
            femaleNames.Add("Brook");
            femaleNames.Add("Sarah");
            femaleNames.Add("Julie");
            femaleNames.Add("Jackie");


            List<string> firstName = new List<string>();

            int selectGenderString = Logic.RollRandomNumber(0, 2);
            string gender;

            if (selectGenderString == 0)
            {
                firstName = maleNames;
                gender = "Male";
            }
            else
            {
                firstName = femaleNames;
                gender = "Female";
            }



            int selectFirstName = Logic.RollRandomNumber(0, 50);

            List<string> lastName = new List<string>();

            lastName.Add("Butler");
            lastName.Add("Nix");
            lastName.Add("Smith");
            lastName.Add("Barber");
            lastName.Add("Campbell");
            lastName.Add("Gibson");
            lastName.Add("Ackles");
            lastName.Add("Williamson");
            lastName.Add("Bronson");
            lastName.Add("Jones");
            lastName.Add("Brown");
            lastName.Add("Miller");
            lastName.Add("Kennedy");
            lastName.Add("Wilson");
            lastName.Add("Anderson");
            lastName.Add("Moore");
            lastName.Add("Martin");
            lastName.Add("Thompson");
            lastName.Add("Harris");
            lastName.Add("Harper");
            lastName.Add("White");
            lastName.Add("Clark");
            lastName.Add("Robinson");
            lastName.Add("Scott");
            lastName.Add("Wright");
            lastName.Add("Hill");
            lastName.Add("Green");
            lastName.Add("Adams");
            lastName.Add("Baker");
            lastName.Add("Nelson");
            lastName.Add("Hall");
            lastName.Add("Mitchell");
            lastName.Add("Carter");
            lastName.Add("Turner");
            lastName.Add("Parker");
            lastName.Add("Edwards");
            lastName.Add("Collins");
            lastName.Add("Rogers");
            lastName.Add("Cook");
            lastName.Add("Morgan");
            lastName.Add("Peterson");
            lastName.Add("Reed");
            lastName.Add("Kelly");
            lastName.Add("Howard");
            lastName.Add("Ward");
            lastName.Add("Richardson");
            lastName.Add("Watson");
            lastName.Add("Watts");
            lastName.Add("Wood");
            lastName.Add("James");

            List<string> streetAddress = new List<string>();

            streetAddress.Add("Victoria");
            streetAddress.Add("Sykes");
            streetAddress.Add("Parker");
            streetAddress.Add("Johnson");
            streetAddress.Add("Abbey");
            streetAddress.Add("Route");
            streetAddress.Add("Jefferson");
            streetAddress.Add("Dick");
            streetAddress.Add("Albion");
            streetAddress.Add("Albert");
            streetAddress.Add("Pine");
            streetAddress.Add("Park");
            streetAddress.Add("Jackson");
            streetAddress.Add("Spruce");
            streetAddress.Add("Birch");
            streetAddress.Add("Willow");
            streetAddress.Add("Sunset");
            streetAddress.Add("Maple");
            streetAddress.Add("Dogwood");
            streetAddress.Add("Redwood");
            streetAddress.Add("Hillside");
            streetAddress.Add("Ridge");
            streetAddress.Add("Evergreen");
            streetAddress.Add("Holly");
            streetAddress.Add("Bay");
            streetAddress.Add("Williams");
            streetAddress.Add("Lake");
            streetAddress.Add("Lakeview");
            streetAddress.Add("Lincoln");
            streetAddress.Add("Hickory");
            streetAddress.Add("Washington");
            streetAddress.Add("Shore");
            streetAddress.Add("Hamlock");
            streetAddress.Add("Cottonwood");
            streetAddress.Add("Mountain View");
            streetAddress.Add("Elm");
            streetAddress.Add("Heights");
            streetAddress.Add("Hollow");
            streetAddress.Add("Lock");
            streetAddress.Add("Row");
            streetAddress.Add("Everglade");
            streetAddress.Add("Eaton");
            streetAddress.Add("Chester");
            streetAddress.Add("Knightsbridge");
            streetAddress.Add("Stein");
            streetAddress.Add("Wellington");
            streetAddress.Add("Paramore");
            streetAddress.Add("Laygon");
            streetAddress.Add("Halkin");
            streetAddress.Add("Graham");

            List<string> streetAddressDirection = new List<string>();

            streetAddressDirection.Add("North");
            streetAddressDirection.Add("East");
            streetAddressDirection.Add("South");
            streetAddressDirection.Add("West");

            List<string> LikesAndDislikes = new List<string>();

            LikesAndDislikes.Add("Books");
            LikesAndDislikes.Add("People");
            LikesAndDislikes.Add("Guns");
            LikesAndDislikes.Add("Cats");
            LikesAndDislikes.Add("Dogs");
            LikesAndDislikes.Add("Spiders");
            LikesAndDislikes.Add("Bugs");
            LikesAndDislikes.Add("The Ocean");
            LikesAndDislikes.Add("Rain");
            LikesAndDislikes.Add("The Sun");
            LikesAndDislikes.Add("Children");
            LikesAndDislikes.Add("Religion");
            LikesAndDislikes.Add("Soda");
            LikesAndDislikes.Add("Chocolate");
            LikesAndDislikes.Add("Pizza");
            LikesAndDislikes.Add("Weapons");
            LikesAndDislikes.Add("Pop-music");
            LikesAndDislikes.Add("Rock Music");
            LikesAndDislikes.Add("Insects");
            LikesAndDislikes.Add("Sports");
            LikesAndDislikes.Add("Small-Talk");
            LikesAndDislikes.Add("Exercise");
            LikesAndDislikes.Add("Formal Wear");
            LikesAndDislikes.Add("Social Media");
            LikesAndDislikes.Add("Cars");
            LikesAndDislikes.Add("Trucks");
            LikesAndDislikes.Add("Christmas");
            LikesAndDislikes.Add("Halloween");
            LikesAndDislikes.Add("Summer");
            LikesAndDislikes.Add("Winter");
            LikesAndDislikes.Add("Horror Movies");
            LikesAndDislikes.Add("RomComs");
            LikesAndDislikes.Add("Thrillers");
            LikesAndDislikes.Add("Handshakes");
            LikesAndDislikes.Add("Technology");
            LikesAndDislikes.Add("Sweet Things");
            LikesAndDislikes.Add("Salty Things");
            LikesAndDislikes.Add("Sour Things");
            LikesAndDislikes.Add("Spicy Things");
            LikesAndDislikes.Add("Competitive Games");
            LikesAndDislikes.Add("RPG Games");
            LikesAndDislikes.Add("FPS Games");
            LikesAndDislikes.Add("MMO Games");
            LikesAndDislikes.Add("Horror Games");
            LikesAndDislikes.Add("Lectures");
            LikesAndDislikes.Add("Texting");
            LikesAndDislikes.Add("Working");

            int selectLastName = Logic.RollRandomNumber(0, 50);

            npc.BirthMonth = Logic.RollRandomNumber(1, 13);
            npc.BirthDay = Logic.RollRandomNumber(1, 31);
            npc.Age = Logic.RollRandomNumber(2, 89);
            npc.BirthYear = AgeToBirthdate(npc.Age);

            int selectStreetNumber = Logic.RollRandomNumber(80, 427);

            int selectStreetAddress = Logic.RollRandomNumber(0, 50);

            int selectStreetDirection = Logic.RollRandomNumber(0, 4);

            DateTime date = DateTime.Now;
            npc.isIllegal = MakeIllegal();
            SetIDExperation(date, npc);

            npc.FirstName = firstName[selectFirstName];
            npc.LastName = lastName[selectLastName];
            npc.Gender = gender;
            npc.StreetNumber = selectStreetNumber;
            npc.StreetAddress = streetAddress[selectStreetAddress];
            npc.StreetDirection = streetAddressDirection[selectStreetDirection];
            return npc;
        }

        public static int AgeToBirthdate(int Age)
        {
            NPC npc = new NPC();

            DateTime localDate = DateTime.Now;
            Age = localDate.Year - Age;

            // If their birthday is in the coming months OR its the same month but its in the coming days, -1 to their age.

            if (npc.BirthMonth > localDate.Month || npc.BirthMonth == localDate.Month && npc.BirthDay > localDate.Day)
            {
                Age--;
            }

            return Age;
        }

        public static bool MakeIllegal()
        {
            int illegalChance = 35;
            int roll = Logic.RollRandomNumber(1, 101);

            if (roll > illegalChance)
            {
                return false;
            }
            return true;
        }

        public static void ShowNpcID(NPC npc)
        {
            //Console.WriteLine(npc.IsIllegal);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("ID GIVEN");
            Console.WriteLine("--------");
            Console.WriteLine($"First Name: {npc.FirstName}");
            Console.WriteLine($"Last Name: {npc.LastName}");
            Console.WriteLine($"Birthday: {npc.BirthMonth}/{npc.BirthDay}/{npc.BirthYear}");
            Console.WriteLine($"Gender: {npc.Gender}");
            Console.WriteLine($"Home Address: {npc.StreetNumber} {npc.StreetAddress} street {npc.StreetDirection}");
            Console.WriteLine($"Expiration Date: {npc.ExpirationMonth}/{npc.ExpirationDay}/{npc.ExpirationYear}");
            Console.ResetColor();
        }

        public static void SetIDExperation(DateTime date, NPC npc)
        {
            // Set expiration date. 
            do
            {
                npc.ExpirationMonth = Logic.RollRandomNumber(1, 11);
                npc.ExpirationDay = Logic.RollRandomNumber(1, 29);
                npc.ExpirationYear = date.Year + Logic.RollRandomNumber(0, 3);
            } while (npc.ExpirationMonth > 12 || npc.ExpirationDay > 30 && (npc.ErrorType != (int)Logic.IDErrorType.ExpirationDate));

            // If NPC is illegal && errortype is expiredID, randomly choose one of the dates and subtract it to make it expired.
            if (npc.isIllegal == true && npc.ErrorType == (int)Logic.IDErrorType.ExpirationDate)
            {
                do
                {
                    int randomRoll = Logic.RollRandomNumber(1, 4);

                    switch (randomRoll)
                    {
                        case 1:
                            npc.ExpirationMonth = date.Month - Logic.RollRandomNumber(1, 11);
                            // To make sure it is current year... 
                            npc.ExpirationYear = date.Year;
                            break;
                        case 2:
                            npc.ExpirationDay = date.Day - Logic.RollRandomNumber(1, 29);
                            break;
                        case 3:
                            npc.ExpirationYear = date.Year - Logic.RollRandomNumber(1, 3);
                            break;
                    }
                } while (npc.expirationMonth < 1 || npc.expirationDay < 1);
            }
            else
            {
                /* This is to make it less obvious on the dates NOT being expired. It makes sure that the expired date is closer
                 * to whatever current date it is. if expired date is of current year AND month, increase the days by X amount. 
                 * else if it of the same year, increase the month by X amount.
                 * (Code is complete and utter TRASH, I'M AWARE.)
                 */
                do
                {
                    if (npc.ExpirationYear == date.Year && npc.ExpirationMonth == date.Month)
                    {
                        npc.ExpirationDay = date.Day + Logic.RollRandomNumber(1, 16);
                    }
                    else if (npc.ExpirationYear == date.Year)
                    {
                        npc.ExpirationMonth = date.Month + Logic.RollRandomNumber(0, 7);
                        // If expired day less than current date, increase expired date by X amount. 
                        if (npc.ExpirationDay < date.Day)
                        {
                            npc.expirationDay = date.Day + Logic.RollRandomNumber(1, 16);
                        }
                    }
                } while (npc.ExpirationMonth > 12 || npc.ExpirationDay > 30);
            }
        }

        public static void SelectIDError(NPC npc)
        {
            int roll = Logic.RollRandomNumber(1, 11);

            switch (roll)
            {
                case 1:
                    {
                        npc.ErrorType = (int)Logic.IDErrorType.FirstName;
                        npc.FirstName = Logic.RemoveLetter(npc.FirstName);
                        break;
                    }
                case 2:
                    {
                        npc.ErrorType = (int)Logic.IDErrorType.LastName;
                        npc.LastName = Logic.RemoveLetter(npc.LastName);
                        break;
                    }
                case 3:
                    {
                        npc.ErrorType = (int)Logic.IDErrorType.BirthMonth;
                        npc.BirthMonth = Logic.ChangeNumber(npc.BirthMonth);
                        break;
                    }
                case 4:
                    {
                        npc.ErrorType = (int)Logic.IDErrorType.BirthDay;
                        npc.BirthDay = Logic.ChangeNumber(npc.BirthDay);
                        break;
                    }
                case 5:
                    {
                        npc.ErrorType = (int)Logic.IDErrorType.BirthYear;
                        npc.BirthYear = Logic.ChangeNumber(npc.BirthYear);
                        break;
                    }
                case 6:
                    {
                        npc.ErrorType = (int)Logic.IDErrorType.Gender;
                        // CHANGE GENDER
                        break;
                    }
                case 7:
                    {
                        npc.ErrorType = (int)Logic.IDErrorType.StreetAddress;
                        npc.StreetAddress = Logic.RemoveLetter(npc.StreetAddress);
                        break;
                    }
                case 8:
                    {
                        npc.ErrorType = (int)Logic.IDErrorType.StreetNumber;
                        npc.StreetNumber = Logic.ChangeNumber(npc.StreetNumber);
                        break;
                    }
                case 9:
                    {
                        npc.ErrorType = (int)Logic.IDErrorType.StreetDirection;
                        // CHANGE DIRECTION
                        break;
                    }
                case 10:
                    {
                        DateTime date = DateTime.Now;
                        npc.ErrorType = (int)Logic.IDErrorType.ExpirationDate;
                        SetIDExperation(date, npc);
                        break;
                    }
            }
        }
    }
}

/*

TODO: 

CHANGE DIRECTION AND GENDER.... THEN THE MEATY STUFF.
*/

