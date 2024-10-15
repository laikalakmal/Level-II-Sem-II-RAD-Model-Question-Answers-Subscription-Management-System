using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Subscription_Management_System.Subscriptions;

namespace Subscription_Management_System
{
    public partial class SubscriptionDetails : Form
    {
        public SubscriptionDetails()
        {
            InitializeComponent();
        }
        public void ShowInputs(IPlan plan)
        {
            label8.Text = plan.GetType().Name;
            if (plan is not FamilyPlan)
            {
                label7.Hide();
                label2.Hide();
            }
            else
            {
                FamilyPlan fplan = (FamilyPlan)plan;
                label7.Text=fplan.Members.ToString();


            }
            label6.Text = plan.PlanDuration.ToString();
            label5.Text = plan.CalCost().ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserInput().Show();
        }
    }
}
