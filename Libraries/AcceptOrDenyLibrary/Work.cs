using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AcceptOrDenyLibrary
{
    public class Work
    {
        private int dayWage;
        private int currentDay;
        private int lineupCount;
        private double bonusPayTotal;
        private int todaysCorrectJudgements;
        private int todaysIncorrectJudgements;
        private int weeksCorrectJudgements;
        private int weeksIncorrectJudgements;
        private int alltimeCorrectJudgements;
        private int alltimeIncorrectJudgements;
        private double moneyPerCorrectChoice;
        private int moneyPerWrongChoice;
        private int moneyLost;
        private double moneyGained;


        public int DayWage
        {
            get { return dayWage; }
            set { dayWage = value; }
        }

        public int CurrentDay
        {
            get { return currentDay; }
            set { currentDay = value; }
        }

        public int LineupCount
        {
            get { return lineupCount; }
            set { lineupCount = value; }
        }

        public double BonusPayTotal
        {
            get { return bonusPayTotal; }
            set { bonusPayTotal = value; }
        }

        public int TodaysCorrectJudgements
        {
            get { return todaysCorrectJudgements; }
            set { todaysCorrectJudgements = value; }
        }

        public int TodaysIncorrectJudgements
        {
            get { return todaysIncorrectJudgements; }
            set { todaysIncorrectJudgements = value; }
        }

        public int WeeksCorrectJudgements
        {
            get { return weeksCorrectJudgements; }
            set { weeksCorrectJudgements = value; }
        }

        public int WeeksIncorrectJudgements
        {
            get { return weeksIncorrectJudgements; }
            set { weeksIncorrectJudgements = value; }
        }

        public int AlltimeCorrectJudgements
        {
            get { return alltimeCorrectJudgements; }
            set { alltimeCorrectJudgements = value; }
        }

        public int AlltimeIncorrectJudgements
        {
            get { return alltimeIncorrectJudgements; }
            set { alltimeIncorrectJudgements = value; }
        }

        public double MoneyPerCorrectChoice
        {
            get { return moneyPerCorrectChoice; }
            set { moneyPerCorrectChoice = value; }
        }

        public int MoneyPerWrongChoice
        {
            get { return moneyPerWrongChoice; }
            set { moneyPerWrongChoice = value; }
        }

        public int MoneyLost
        {
            get { return moneyLost; }
            set { moneyLost = value; }
        }

        public double MoneyGained
        {
            get { return moneyGained; }
            set { moneyGained = value; }
        }

        public Work()
        {
            dayWage = 50;
            currentDay = 1;
            lineupCount = 10;
            bonusPayTotal = 0;
            todaysCorrectJudgements = 0;
            todaysIncorrectJudgements = 0;
            weeksCorrectJudgements = 0;
            weeksIncorrectJudgements = 0;
            alltimeCorrectJudgements = 0;
            alltimeIncorrectJudgements = 0;
            moneyPerCorrectChoice = 0.25;
            moneyPerWrongChoice = 10;
            moneyLost = 0;
            moneyGained = 0;
        }

        public static void Working(Bills bill, Player player, Work work)
        {
            Logic.SaveGame(bill, player, work);

            do
            {
                Console.Clear();
                NPC npc = new NPC().GenerateNPC();
                NPC npcComputerInfo = new NPC(npc);

                if (npc.IsIllegal) { NPC.SelectIDError(npc); }
                if (npc.ErrorType == (int)Logic.IDErrorType.ExpirationDate)
                {
                    npcComputerInfo = new NPC(npc);
                }

                HeaderScreen(work, player);

                ShowMonitor(npcComputerInfo);

                NPC.ShowNpcID(npc);

                MakeChoice(npc, work);
            } while (work.lineupCount > 0);

            Console.Clear();
            EndDayScreen(bill, player, work);
        }

        public static void HeaderScreen(Work work, Player player)
        {
            DateTime localDate = DateTime.Now;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"People in line: {work.lineupCount}\tDays Employed: {player.DaysEmployed}\tCurrent Day: {localDate.Month}/{localDate.Day}/{localDate.Year}");
            Console.WriteLine("-----------------------------------------------------------------------\n");
            Console.ResetColor();
        }

        public static void ShowMonitor(NPC npcComputerInfo)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("COMPUTER SCREEN");
            Console.WriteLine("===============");
            Console.WriteLine($"First Name: {npcComputerInfo.FirstName}");
            Console.WriteLine($"Last Name: {npcComputerInfo.LastName}");
            Console.WriteLine($"Birthday: {npcComputerInfo.BirthMonth}/{npcComputerInfo.BirthDay}/{npcComputerInfo.BirthYear}");
            Console.WriteLine($"Gender: {npcComputerInfo.Gender}");
            Console.WriteLine($"Home Address: {npcComputerInfo.StreetNumber} {npcComputerInfo.StreetAddress} street {npcComputerInfo.StreetDirection}");
            Console.WriteLine($"Expiration Date: {npcComputerInfo.ExpirationMonth}/{npcComputerInfo.ExpirationDay}/{npcComputerInfo.ExpirationYear}\n");
            Console.ResetColor();
        }

        public static void MakeChoice(NPC npc, Work work)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n-----------------------------------------------");
            Console.WriteLine("1) Accept Entry");
            Console.WriteLine("2) Deny Entry\n");

            Console.Write("Input: ");
            Console.ResetColor();

            string choice = Console.ReadLine();

            if (choice == "1" && npc.IsIllegal == false) 
            {
                IncreaseCorrectJudgement(work);
            }
            else if (choice == "2" && npc.IsIllegal == true)
            {
                IncreaseCorrectJudgement(work);
            }
            else
            {
                IncreaseIncorrectJudgement(work, npc);
            }

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();

            work.LineupCount--;
        }

        public static void IncreaseCorrectJudgement(Work work)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Correct!");
            Console.ResetColor();
            work.TodaysCorrectJudgements++;
        }

        public static void IncreaseIncorrectJudgement(Work work, NPC npc)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Incorrect! the error was their {npc.ErrorTypeString}.");
            Console.ResetColor();
            work.TodaysIncorrectJudgements++;
        }

        public static void EndDayScreen(Bills bill, Player player, Work work)
        {
            TallyUpMoney(player, work);

            Console.WriteLine($"Days Wage: ${work.DayWage}\n");

            Console.WriteLine($"Correct Judgements: {work.TodaysCorrectJudgements}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Bonus Money: ${work.bonusPayTotal}");
            Console.ResetColor();
            Console.WriteLine($"\nIncorrect Judgements: {work.TodaysIncorrectJudgements}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Money Docked: ${work.MoneyLost}");
            Console.ResetColor();

            if (work.MoneyGained <= 0) { Console.ForegroundColor = ConsoleColor.Red; }
            else { Console.ForegroundColor = ConsoleColor.Green; }

            Console.WriteLine($"\nTotal money gained/lost: ${work.MoneyGained}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"New bank balance: ${player.Money}");
            Console.ResetColor();
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
            Bills.PayBillsScreen(bill, player);

            if (player.Money > 0)
            {
                Console.WriteLine("You live to work another day... Press Enter to get back to work.");
                Console.ReadLine();
                work.LineupCount = Logic.RollRandomNumber(5, 16);

                // To reset some stuff and to increase some things

                bill.TotalBill = 0;
                work.AlltimeCorrectJudgements = work.AlltimeCorrectJudgements + work.todaysCorrectJudgements;
                work.AlltimeIncorrectJudgements = work.AlltimeIncorrectJudgements + work.todaysIncorrectJudgements;
                work.WeeksCorrectJudgements = work.WeeksCorrectJudgements + work.TodaysCorrectJudgements;
                work.WeeksIncorrectJudgements = work.WeeksIncorrectJudgements + work.TodaysIncorrectJudgements;
                work.TodaysCorrectJudgements = 0;
                work.TodaysIncorrectJudgements = 0;
                player.DaysEmployed = player.DaysEmployed + 1;

                CheckForPromotion(player, work);

                Working(bill, player, work);
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("You went bankrupt! ALL IS LOST!");
                Console.ReadLine();
                Console.ResetColor();
            }
        }

        public static void TallyUpMoney(Player player, Work work)
        {
            work.BonusPayTotal = work.MoneyPerCorrectChoice * work.TodaysCorrectJudgements;
            work.MoneyLost = work.MoneyPerWrongChoice * work.TodaysIncorrectJudgements;

            work.MoneyGained = work.DayWage + work.bonusPayTotal - work.MoneyLost;
            player.Money = player.Money + work.MoneyGained;
        }

        public static void CheckForPromotion(Player player, Work work)
        {
            int wageThen = work.DayWage;
            work.DayWage = work.DayWage + 10;

            if (work.WeeksIncorrectJudgements == 0 && work.CurrentDay >= 7)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("You've been promoted!");
                Console.WriteLine($"Your wage is now going from ${wageThen} to ${work.DayWage}. Congratulations!\n");
                Console.ResetColor();

                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();

                work.CurrentDay = 1;
            }
            else if (work.WeeksIncorrectJudgements > 0 && work.CurrentDay == 7)
            {
                work.CurrentDay = 1;
            }
            else
            {
                work.currentDay = work.CurrentDay + 1;
            }
        }
    }
}
