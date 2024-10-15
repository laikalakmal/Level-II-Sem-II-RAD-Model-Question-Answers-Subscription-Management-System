using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscription_Management_System.Subscriptions
{
    internal class BasicPlan : IPlan
    {
        private static string name = "Basic Subscription";
        public static string Name { get { return name; } set { name = value; } }
        public static List<string> Discription { get => discription; set => discription = value; }
        private static List<string> discription;
        public int PlanDuration { get; set; }
        static BasicPlan()
        {
            discription = new List<string>();
            Discription.Add("Access to SD content");
            Discription.Add("Ads included");
        }
        public BasicPlan(int planDuration)
        {
            PlanDuration = planDuration;
        }
        public decimal CalCost()
        {
            return PlanDuration * 10;
        }
    }
}
