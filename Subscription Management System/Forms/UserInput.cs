using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Subscription_Management_System.Subscriptions;

namespace Subscription_Management_System
{
    public partial class UserInput : Form
    {
        private IPlan plan;

        public UserInput()
        {
            InitializeComponent();
            comboBox1.Items.Add(FamilyPlan.Name);
            comboBox1.Items.Add(PremiumPlan.Name);
            comboBox1.Items.Add(BasicPlan.Name);
            //add new plans here when needed
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = comboBox1.SelectedItem.ToString();

            if (selectedType == FamilyPlan.Name)
            {
                numericUpDown1.Enabled = true;

            }
            else { numericUpDown1.Enabled = false; }

            if (selectedType == PremiumPlan.Name) { listBox1.DataSource = PremiumPlan.Discription; }
            else if (selectedType == BasicPlan.Name) { listBox1.DataSource = BasicPlan.Discription; }
            else if (selectedType == FamilyPlan.Name) { listBox1.DataSource = FamilyPlan.Discription; }
            //add new plans when needed
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string selectedType = comboBox1.SelectedItem.ToString();

            int months = ((int)numericUpDown2.Value);

            if (numericUpDown1.Enabled)
            {
                plan = PlanFactory.BuyPlan(selectedType, months, ((int)numericUpDown1.Value));
            }
            else if (!numericUpDown1.Enabled)
            {
                plan = PlanFactory.BuyPlan(selectedType, months);
            }
            this.Hide();

            SubscriptionDetails frm = new SubscriptionDetails();
            frm.ShowInputs(plan);
            frm.Show();



        }

        private void UserInput_Load(object sender, EventArgs e)
        {

        }
    }
}
