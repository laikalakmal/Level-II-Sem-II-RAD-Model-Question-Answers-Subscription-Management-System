using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscription_Management_System.Subscriptions
{
    internal class FamilyPlan : IPlan
    {
        private static List<string> discription;
        public static List<string> Discription { get => discription; set => discription = value; }

        private static string name = "Family Subscription";
        public static string Name { get { return name; } set { name = value; } }
        public int PlanDuration { get; set; }
        private int members;
        public int Members
        {

            get { return members; }

            set
            {
                if (value >= 1)
                {
                    members = value;
                }
                else
                {
                    throw new ArgumentException("at least one user should be");
                }
            }
        }
        public FamilyPlan(int planDuration, int members)
        {
            PlanDuration = planDuration;
            Members = members;
        }
        static FamilyPlan()
        {
            discription = new List<string>();
            Discription.Add("Access to HD content");
            Discription.Add("Offline downloads");
            Discription.Add("No Ads");
        }
        public decimal CalCost()
        {
            decimal costPerMonth = 0;
            int i = Members;
            do
            {
                if (i == 1)
                {
                    costPerMonth += 30;
                }
                else
                {
                    costPerMonth += 5;
                }
                i--;

            }
            while (i > 0);

            return costPerMonth * PlanDuration;
        }
    }
}
