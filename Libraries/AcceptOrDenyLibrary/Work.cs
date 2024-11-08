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
        private int currentLineup;
        private int totalLineup;
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

        public int CurrentLineup
        {
            get { return currentLineup; }
            set { currentLineup = value; }
        }

        public int TotalLineup
        {
            get { return totalLineup; }
            set { TotalLineup = value; }
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
            currentLineup = 10;
            totalLineup = 10;
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
            } while (work.CurrentLineup > 0);

            Console.Clear();
            EndDayScreen(bill, player, work);
        }

        public static void HeaderScreen(Work work, Player player)
        {
            DateTime localDate = DateTime.Now;

            Console.ForegroundColor = ConsoleColor.Yellow;
            // 3 spaces for the | 
            Console.WriteLine($"People in line: {work.CurrentLineup}   |   Days Employed: {player.DaysEmployed}   |   Current Day: {localDate.Month}/{localDate.Day}/{localDate.Year}   |   Name: {player.FirstName} {player.LastName}");
            Console.WriteLine("------------------------------------------------------------------------------------------------------\n");
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

            work.CurrentLineup--;
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
            Console.WriteLine($"New bank balance: ${player.Money}\n");
            Console.ResetColor();
            BossEndOfDayComment(player, work);

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();

            Bills.PayBillsScreen(bill, player);

            if (player.Money > 0)
            {
                Console.WriteLine("You live to work another day... Press Enter to get back to work.");
                Console.ReadLine();
                work.CurrentLineup = Logic.RollRandomNumber(5, 16);

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

            if (work.WeeksIncorrectJudgements == 0 && work.CurrentDay >= 7)
            {
                work.DayWage = work.DayWage + 10;

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("You've been promoted!");
                Console.WriteLine($"Your wage is now going from ${wageThen} to ${work.DayWage}. Congratulations!\n");
                Console.ResetColor();

                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();

                work.CurrentDay = 1;
                work.WeeksCorrectJudgements = 0;
            }
            else if (work.WeeksIncorrectJudgements >= 17 && work.CurrentDay == 7)
            {
                work.DayWage = work.DayWage - 10;

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You've been demoted!");
                Console.WriteLine($"Your wage is now going from ${wageThen} to ${work.DayWage}. stop fucking up!\n");
                Console.ResetColor();

                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();

                work.CurrentDay = 1;
                work.WeeksIncorrectJudgements = 0;
            }
            else if (work.CurrentDay == 7)
            {
                work.CurrentDay = 0;
                work.WeeksCorrectJudgements = 0;
                work.WeeksIncorrectJudgements = 0;
            }

            work.currentDay = work.CurrentDay + 1;
        }

        public static void BossEndOfDayComment(Player player, Work work)
        {
            string bossComment = "pizza";
            int commentSelected = 0;
            int dividedLineup = work.TotalLineup / 2;

            List<string> worstDayComments = new List<string>();

            worstDayComments.Add($"YOU FUCKING SUCKED TODAY {player.FirstName.ToUpper()}! DO BETTER NEXT TIME... IF THERE IS A NEXT TIME.");
            worstDayComments.Add($"WHAT THE HELL HAPPEND TODAY? YOU FUCKED UP BAD {player.FirstName.ToUpper()}!");
            worstDayComments.Add($"YOU ARE A MSSIVE FAILURE TO OUR COUNTRY {player.FirstName.ToUpper()}!");

            List<string> badDayComments = new List<string>();

            badDayComments.Add($"Hey {player.FirstName}, you tired? WELL TOO BAD! DO BETTER NEXT TIME.");
            badDayComments.Add($"Your not a complete failure, but... you should have done better today {player.FirstName}.");
            badDayComments.Add($"You get a C today {player.FirstName}. that is all.");

            List<string> averageDayComments = new List<string>();

            averageDayComments.Add($"Not great, but not bad either today {player.FirstName}.");
            averageDayComments.Add($"Decent work today {player.FirstName}.");
            averageDayComments.Add($"Eh.. today could have been worse.");

            List<string> goodDayComments = new List<string>();

            goodDayComments.Add($"Good job today {player.FirstName}!");
            goodDayComments.Add($"Keep up the good work {player.FirstName}!");
            goodDayComments.Add($"{player.FirstName}, you did well today. I hope to see that tomorrow as well!");

            List<string> bestDayComments = new List<string>();

            bestDayComments.Add($"You did flawless today {player.FirstName}. well done!");
            bestDayComments.Add($"Amazing job today {player.FirstName}!");
            bestDayComments.Add($"{player.FirstName}, you did beyond amazing today. I hope to see more of that!");

            if (work.TodaysIncorrectJudgements == work.TotalLineup)
            {
                commentSelected = Logic.RollRandomNumber(0, worstDayComments.Count);
                bossComment = worstDayComments[commentSelected];
            }
            else if (work.TodaysCorrectJudgements == work.TotalLineup)
            {
                commentSelected = Logic.RollRandomNumber(0, bestDayComments.Count );
                bossComment = bestDayComments[commentSelected];
            }
            else if (work.TodaysIncorrectJudgements == work.TodaysCorrectJudgements)
            {
                commentSelected = Logic.RollRandomNumber(0, averageDayComments.Count);
                bossComment = averageDayComments[commentSelected];
            }
            else if (work.TodaysCorrectJudgements > dividedLineup)
            {
                commentSelected = Logic.RollRandomNumber(0, goodDayComments.Count);
                bossComment = goodDayComments[commentSelected];
            }
            else if (work.TodaysIncorrectJudgements > dividedLineup)
            {
                commentSelected = Logic.RollRandomNumber(0, badDayComments.Count);
                bossComment = badDayComments[commentSelected];
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Boss: {bossComment}");
            
            Console.ResetColor();
        }
    }
}
