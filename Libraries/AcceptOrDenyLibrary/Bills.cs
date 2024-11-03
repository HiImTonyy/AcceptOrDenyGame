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
        private int ivate;
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

        public Bills()
        {
            foodCost = 15;
            electricityCost = 70;
            rentCost = 300;
            foodBillDate = 1;
            electricityBillDate = 14;
            rentBillDate= 27;
        }
    }
}
