using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcceptOrDenyLibrary
{
    public class Logic
    {
        public static int CreateRandomNumber(int minNumber, int maxNumber)
        {
            Random random = new Random();
            int numberSelected = random.Next(minNumber, maxNumber);
            return numberSelected;
        }

        public enum IDErrorType
        {
            FirstName = 1,
            LastName,
            Birthday,
            Gender,
            StreetAddress,
            StreetNumber,
            StreetDirection,
            ExpirationDate
        }

        public static string RemoveLetter(string name)
        {
            int index = Logic.CreateRandomNumber(1, name.Length - 1);
            name = name.Remove(index, 1);
            return name;
        }
    }
}
