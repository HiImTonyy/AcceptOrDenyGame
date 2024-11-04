using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcceptOrDenyLibrary
{
    public class Bills
    {
        private int foodCost;
        private int electricityCost;
        private int rentCost;
        private int foodBillDate;
        private int electricityBillDate;
        private int rentBillDate;
        private int totalBill;
        public int FoodCost
        {
            get { return foodCost; }
            set { foodCost = value; }
        }

        public int ElectricityCost
        {
            get { return electricityCost; }
            set { electricityCost = value; }
        }

        public int RentCost
        {
            get { return rentCost; }
            set { rentCost = value; }
        }

        public int FoodBillDate
        {
            get { return foodBillDate; }
            set { foodBillDate = value; }
        }

        public int ElectricityBillDate
        {
            get { return electricityBillDate; }
            set { electricityBillDate = value; }
        }

        public int RentBillDate
        {
            get { return rentBillDate; }
            set { rentBillDate = value; }
        }

        public int TotalBill
        {
            get { return totalBill; }
            set { totalBill = value; }
        }

        public Bills()
        {
            foodCost = 15;
            electricityCost = 70;
            rentCost = 300;
            foodBillDate = 1;
            electricityBillDate = 14;
            rentBillDate= 27;
            totalBill = 0;
        }

        public static void PayBillsScreen(Player player)
        {
            Bills bill = new Bills();

            DecreaseBillDates(bill);
            Console.WriteLine($"Days till Electricity Bill: {bill.FoodBillDate}");
            Console.WriteLine($"Days till Electricity Bill: {bill.ElectricityBillDate}");
            Console.WriteLine($"Days till Rent Bill: {bill.RentBillDate}\n");

            PayBills(player, bill);

            Console.WriteLine($"Total Bill Amount: {bill.TotalBill}");
            Console.WriteLine($"Bank Balance: {player.Money}");
            Console.ReadLine();
        }

        public static void DecreaseBillDates(Bills bill)
        {
            bill.FoodBillDate--;
            bill.ElectricityBillDate--;
            bill.RentBillDate--;
        }

        public static void PayBills(Player player, Bills bill)
        {
            if (bill.FoodBillDate == 0) 
            { 
                bill.totalBill = bill.TotalBill + bill.FoodCost;
                bill.FoodBillDate++;
            }
            if (bill.ElectricityBillDate == 0) 
            { 
                bill.totalBill = bill.TotalBill + bill.ElectricityCost;
                bill.ElectricityBillDate = 14;
            }
            if (bill.RentBillDate == 0) 
            { 
                bill.totalBill = bill.TotalBill + bill.RentCost;
                bill.RentBillDate = 27;
            }

            player.Money = player.Money - bill.TotalBill;
        }
    }

    // NEED TO ADD TOTAL MONEY GAINED TO PLAYERS MONEY AT END DAY SCREEN.. TALLY UP STUFF.
}