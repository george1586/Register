namespace WinFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnCalculateProfit = new Button();
            btnCalculateExpenses = new Button();
            btnCountUsers = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnCalculateProfit);
            panel1.Controls.Add(btnCalculateExpenses);
            panel1.Controls.Add(btnCountUsers);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 450);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(60, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnCalculateProfit
            // 
            btnCalculateProfit.BackColor = Color.Black;
            btnCalculateProfit.Cursor = Cursors.Hand;
            btnCalculateProfit.Font = new Font("MS UI Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalculateProfit.ForeColor = Color.White;
            btnCalculateProfit.Location = new Point(60, 342);
            btnCalculateProfit.Name = "btnExit";
            btnCalculateProfit.Size = new Size(119, 58);
            btnCalculateProfit.TabIndex = 2;
            btnCalculateProfit.Text = "Iesire";
            btnCalculateProfit.UseVisualStyleBackColor = false;
            btnCalculateProfit.Click += btnExit_Click;
            // 
            // btnCalculateExpenses
            // 
            btnCalculateExpenses.BackColor = Color.Black;
            btnCalculateExpenses.Cursor = Cursors.Hand;
            btnCalculateExpenses.Font = new Font("MS UI Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalculateExpenses.ForeColor = Color.White;
            btnCalculateExpenses.Location = new Point(60, 258);
            btnCalculateExpenses.Name = "btnCalculateExpenses";
            btnCalculateExpenses.Size = new Size(119, 58);
            btnCalculateExpenses.TabIndex = 1;
            btnCalculateExpenses.Text = "Sales";
            btnCalculateExpenses.UseVisualStyleBackColor = false;
            btnCalculateExpenses.Click += btnCalculateExpenses_Click_1;
            // 
            // btnCountUsers
            // 
            btnCountUsers.BackColor = Color.Black;
            btnCountUsers.Cursor = Cursors.Hand;
            btnCountUsers.Font = new Font("MS UI Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCountUsers.ForeColor = Color.White;
            btnCountUsers.Location = new Point(60, 172);
            btnCountUsers.Name = "btnCountUsers";
            btnCountUsers.Size = new Size(119, 58);
            btnCountUsers.TabIndex = 0;
            btnCountUsers.Text = "Customers";
            btnCountUsers.UseVisualStyleBackColor = false;
            btnCountUsers.Click += btnCountUsers_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCalculateProfit;
        private Button btnCalculateExpenses;
        private Button btnCountUsers;
        private PictureBox pictureBox1;
        private Label lblUsers;
        private Label lblExpenses;
    }
}