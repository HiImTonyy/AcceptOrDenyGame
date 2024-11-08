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
            Player.Home(bill, player, work);
        }

        public static void GameInfo(Bills bill, Player player, Work work)
        {
            Console.Clear();
            NPC npc = new NPC().GenerateNPC();
            Console.ForegroundColor = ConsoleColor.Magenta;

            Work.HeaderScreen(work, player);
            Work.ShowMonitor(npc);
            NPC.ShowNpcID(npc);

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("\nThe point of the game is to accept or deny someone coming into the country.\n");

            Console.WriteLine("The computer screen shows the valid info of the person in-front of you. if the ID given does not match");
            Console.WriteLine("the computer screen, then you must deny them. if it does, accept them. be sure to check the expiration");
            Console.WriteLine("Date as well. if their ID is the same but its expired, deny them.\n");

            Console.WriteLine("The list of things that can be changed are as followed:");
            Console.WriteLine("1 - First Name");
            Console.WriteLine("2 - Last Name");
            Console.WriteLine("3 - Birth Month");
            Console.WriteLine("4 - Birth Day");
            Console.WriteLine("5 - Birth Year");
            Console.WriteLine("6 - Gender");
            Console.WriteLine("7 - Streed Address");
            Console.WriteLine("8 - Street Number");
            Console.WriteLine("9 - Street Direction\n");

            Console.WriteLine("Again, be sure the check the expiration date!\n");

            Console.WriteLine("At the end of the day, you will lose quite a bit of money for each wrong judgement but gain some money");
            Console.WriteLine("for each correct judgement. you will also have to pay any bills that are due. your bills are:");
            Console.WriteLine("Food, Electric, and Rent. IF YOUR BALANCE REACHES 0, YOU LOSE THE GAME!");

            Console.WriteLine("Also, If you do super well by the end of the week, then you will get a promotion. do super bad and");
            Console.WriteLine("you will get demoted. promotion = increased daily wage, demotion = decreased daily wage.");
            Console.WriteLine("You can also view all sorts of stats while at home. and that's that, have fun!\n");

            Console.WriteLine("Press Enter to go back...");
            Console.ReadLine();
        }
    }
}
