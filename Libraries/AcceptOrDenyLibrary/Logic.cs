using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcceptOrDenyLibrary
{
    public class Logic
    {
        public static int RollRandomNumber(int minNumber, int maxNumber)
        {
            Random random = new Random();
            int numberSelected = random.Next(minNumber, maxNumber);
            return numberSelected;
        }

        public enum IDErrorType
        {
            FirstName = 1,
            LastName,
            BirthMonth,
            BirthDay,
            BirthYear,
            Gender,
            StreetAddress,
            StreetNumber,
            StreetDirection,
            ExpirationDate
        }

        public static string RemoveLetter(string name)
        {
            int index = Logic.RollRandomNumber(1, name.Length - 1);
            name = name.Remove(index, 1);
            return name;
        }

        public static int ChangeNumber(int number)
        {
            if (number > 12 && number < 40)
            {
                number = RollRandomNumber(1, number);
            }
            else if  (number < 12)
            {
                number = RollRandomNumber(1, number);
            }
            else if (number > 1000)
            {
                number = number - RollRandomNumber(1, 3);
            }
            else
            {
                number = number + RollRandomNumber(1, 15);
            }

            return number;
        }

        public static string ChangeDirection(NPC npc)
        {
            string currentDirection = npc.StreetDirection;
            int roll = 0;

            do
            {
                roll = RollRandomNumber(1, 5);
                switch (roll)
                {
                    case 1:
                        npc.StreetDirection = "North";
                        break;
                    case 2:
                        npc.StreetDirection = "South";
                        break;
                    case 3:
                        npc.StreetDirection = "East";
                        break;
                    case 4:
                        npc.StreetDirection = "West";
                        break;
                }
            } while ( currentDirection == npc.StreetDirection );

            return npc.StreetDirection;
        }
    }
}
