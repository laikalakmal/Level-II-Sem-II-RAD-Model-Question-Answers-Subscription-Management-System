using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Subscription_Management_System.Subscriptions;

namespace Subscription_Management_System
{
    internal class PlanFactory
    {
        public static IPlan BuyPlan(string type, int months)
        {
            if (type == BasicPlan.Name)
            {
                return new BasicPlan(months);

            }
            else if (type == PremiumPlan.Name)
            {
                return new PremiumPlan(months);
            }
            else
            {
                throw new ArgumentException("No such Plan: "+type);
            }
        }
        public static IPlan BuyPlan(string type, int months,int users)
        {
            if (type == FamilyPlan.Name)
            {
                return new FamilyPlan(months,users);

            }
            else
            {
                throw new ArgumentException("No such Plan: "+type);
            }
        }

    }
}
