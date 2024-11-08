using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text.Json;
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

        public static void SaveGame(Bills bill, Player player, Work work)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(path, "AcceptOrDenySave.txt");

            using (StreamWriter streamWrite = new StreamWriter(filePath))
            {
                streamWrite.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(bill));
                streamWrite.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(player));
                streamWrite.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(work));
            }

            Console.WriteLine("Game saved!");
            Console.WriteLine("Press Enter to contiue.");
            Console.ReadLine();
        }

        public static void LoadGame(Bills bill, Player player, Work work)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(path, "AcceptOrDenySave.txt");

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                if (lines.Length >= 3)
                {
                    bill = Newtonsoft.Json.JsonConvert.DeserializeObject<Bills>(lines[0]);
                    player = Newtonsoft.Json.JsonConvert.DeserializeObject<Player>(lines[1]);
                    work = Newtonsoft.Json.JsonConvert.DeserializeObject<Work>(lines[2]);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("CANNOT LOAD BECAUSE THE SAVE GOT CORRUPTED!");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("NO SAVE FILE FOUND! PRESS ENTER TO CREATE A NEW ONE!");
                Console.ReadLine();
                Console.ResetColor();
                NewGame(bill, player, work);
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Game Loaded!");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            Console.ResetColor();
            Work.Working(bill, player, work);
        }

        public static void NewGame(Bills bill, Player player, Work work)
        {
            Console.Clear();

            player.FirstName = Player.NamePlayer("Write the first name of your new character.");
            player.LastName = Player.NamePlayer("And the last name?");
            Console.Clear();
            Work.Working(bill, player, work);
        }
    }
}
