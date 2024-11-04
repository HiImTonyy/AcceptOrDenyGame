using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcceptOrDenyLibrary
{
    public class Work
    {
        private int dayWage;
        private int currentDay;
        private int lineupCount;
        private int bonusPay;
        private int correctJudgements;
        private int wrongJudgements;

        public int DayWage
        {
            get { return dayWage; }
            set { dayWage = value; }
        }

        public int CurrentDay
        {
            get { return dayWage; }
            set { dayWage = value; }
        }

        public int LineupCount
        {
            get { return lineupCount; }
            set { lineupCount = value; }
        }

        public Work()
        {
            dayWage = 50;
            currentDay = 1;
            lineupCount = 10;
            bonusPay = 0;
            correctJudgements = 0;
            wrongJudgements = 0;
        }

        public static void Working()
        {
            Work work = new Work();

            do
            {
                Console.Clear();
                NPC npc = new NPC().GenerateNPC();
                NPC npcComputerInfo = new NPC(npc);

                if (npc.IsIllegal) {NPC.SelectIDError(npc);}
                if (npc.ErrorType == (int)Logic.IDErrorType.ExpirationDate)
                {
                    npcComputerInfo = new NPC(npc);
                }

                HeaderScreen(work);

                ShowMonitor(npcComputerInfo);
                Console.WriteLine("\n");
                NPC.ShowNpcID(npc);

                Console.ReadLine();
            } while (true);
        }

        public static void HeaderScreen(Work work)
        {
            DateTime localDate = DateTime.Now;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"People in line: {work.lineupCount}\tCurrent Day: {localDate.Month}/{localDate.Day}/{localDate.Year}");
            Console.WriteLine("-----------------------------------------------\n");
            Console.ResetColor();
        }

        public static void ShowMonitor(NPC npcComputerInfo)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("COMPUTER SCREEN");
            Console.WriteLine("---------------");
            Console.WriteLine($"First Name: {npcComputerInfo.FirstName}");
            Console.WriteLine($"Last Name: {npcComputerInfo.LastName}");
            Console.WriteLine($"Birthday: {npcComputerInfo.BirthMonth}/{npcComputerInfo.BirthDay}/{npcComputerInfo.BirthYear}");
            Console.WriteLine($"Gender: {npcComputerInfo.Gender}");
            Console.WriteLine($"Home Address: {npcComputerInfo.StreetNumber} {npcComputerInfo.StreetAddress} street {npcComputerInfo.StreetDirection}");
            Console.WriteLine($"Expiration Date: {npcComputerInfo.ExpirationMonth}/{npcComputerInfo.ExpirationDay}/{npcComputerInfo.ExpirationYear}");
            Console.ResetColor();
        }
    }
}
