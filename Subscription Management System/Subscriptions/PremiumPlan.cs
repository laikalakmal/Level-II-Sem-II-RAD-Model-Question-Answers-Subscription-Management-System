using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscription_Management_System.Subscriptions
{
    internal class PremiumPlan : IPlan
    {
        public int PlanDuration { get; set; }

        private static string name = "Premium Subscription";
        public static string Name { get { return name; } set { name = value; } }

        private static List<string> discription = new List<string>();
        public static List<string> Discription { get => discription; set => discription = value; }

        public PremiumPlan(int planDuration)
        {
            PlanDuration = planDuration;
        }
        static PremiumPlan()
        {
            discription.Add("Access to HD content");
            discription.Add("No Ads");
            discription.Add("Offline downloads");
        }
        public decimal CalCost()
        {
            return PlanDuration * 20;
        }
    }
}
