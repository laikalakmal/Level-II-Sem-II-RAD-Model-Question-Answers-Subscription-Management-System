using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscription_Management_System.Subscriptions
{
    public interface IPlan
    {
        private static string name;

        public static List<string> Discription { get; set; }
        public int PlanDuration { get; set; }
        public static string Name { get => name; set => name = value; }

        public decimal CalCost();
    }
}
