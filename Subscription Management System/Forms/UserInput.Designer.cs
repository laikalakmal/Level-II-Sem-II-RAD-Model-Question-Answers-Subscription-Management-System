namespace Subscription_Management_System
{
    partial class UserInput
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            button1 = new Button();
            listBox1 = new ListBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(261, 62);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(230, 33);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 62);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 3;
            label1.Text = "Subscription Plan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 139);
            label2.Name = "label2";
            label2.Size = new Size(147, 25);
            label2.TabIndex = 4;
            label2.Text = "Number of Users";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 246);
            label3.Name = "label3";
            label3.Size = new Size(261, 25);
            label3.TabIndex = 5;
            label3.Text = "Subscription Period (in months)";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Enabled = false;
            numericUpDown1.Location = new Point(341, 139);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 31);
            numericUpDown1.TabIndex = 6;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(341, 244);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 31);
            numericUpDown2.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(397, 335);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Buy";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(537, 89);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(371, 254);
            listBox1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(537, 43);
            label4.Name = "label4";
            label4.Size = new Size(183, 25);
            label4.TabIndex = 10;
            label4.Text = "Plan-Specific Features";
            // 
            // UserInput
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 534);
            Controls.Add(label4);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "UserInput";
            Text = "UserInput";
            Load += UserInput_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Button button1;
        private ListBox listBox1;
        private Label label4;
    }
}