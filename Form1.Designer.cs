namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            registerclicked = new Label();
            label3 = new Label();
            showpassword_login = new CheckBox();
            login = new Button();
            password_login = new TextBox();
            label1 = new Label();
            username_login = new TextBox();
            Username = new Label();
            Welcome = new Label();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(registerclicked);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(showpassword_login);
            panel1.Controls.Add(login);
            panel1.Controls.Add(password_login);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(username_login);
            panel1.Controls.Add(Username);
            panel1.Controls.Add(Welcome);
            panel1.Controls.Add(panel2);
            panel1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(636, 412);
            panel1.TabIndex = 0;
            // 
            // registerclicked
            // 
            registerclicked.AutoSize = true;
            registerclicked.Cursor = Cursors.Hand;
            registerclicked.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Underline, GraphicsUnit.Point);
            registerclicked.ForeColor = Color.RoyalBlue;
            registerclicked.Location = new Point(460, 349);
            registerclicked.Name = "registerclicked";
            registerclicked.Size = new Size(91, 16);
            registerclicked.TabIndex = 10;
            registerclicked.Text = "Register here.";
            registerclicked.Click += reg_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(317, 349);
            label3.Name = "label3";
            label3.Size = new Size(146, 16);
            label3.TabIndex = 8;
            label3.Text = "Don't have an account?";
            // 
            // showpassword_login
            // 
            showpassword_login.AutoSize = true;
            showpassword_login.BackColor = Color.White;
            showpassword_login.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            showpassword_login.ForeColor = Color.Gray;
            showpassword_login.Location = new Point(507, 251);
            showpassword_login.Name = "showpassword_login";
            showpassword_login.RightToLeft = RightToLeft.Yes;
            showpassword_login.Size = new Size(102, 17);
            showpassword_login.TabIndex = 7;
            showpassword_login.Text = "Show Password";
            showpassword_login.TextAlign = ContentAlignment.TopLeft;
            showpassword_login.UseVisualStyleBackColor = false;
            showpassword_login.CheckedChanged += showpassword_login_CheckedChanged;
            // 
            // login
            // 
            login.BackColor = Color.MediumBlue;
            login.Cursor = Cursors.Hand;
            login.FlatAppearance.BorderSize = 0;
            login.FlatStyle = FlatStyle.Flat;
            login.ForeColor = Color.White;
            login.Location = new Point(317, 292);
            login.Name = "login";
            login.Size = new Size(128, 43);
            login.TabIndex = 6;
            login.Text = "LOG IN";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // password_login
            // 
            password_login.Location = new Point(317, 212);
            password_login.MaxLength = 30;
            password_login.Multiline = true;
            password_login.Name = "password_login";
            password_login.PasswordChar = '*';
            password_login.Size = new Size(292, 33);
            password_login.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(317, 193);
            label1.Name = "label1";
            label1.Size = new Size(67, 16);
            label1.TabIndex = 4;
            label1.Text = "Password";
            // 
            // username_login
            // 
            username_login.Location = new Point(317, 135);
            username_login.MaxLength = 30;
            username_login.Multiline = true;
            username_login.Name = "username_login";
            username_login.Size = new Size(292, 33);
            username_login.TabIndex = 3;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(317, 116);
            Username.Name = "Username";
            Username.Size = new Size(70, 16);
            Username.TabIndex = 2;
            Username.Text = "Username";
            // 
            // Welcome
            // 
            Welcome.AutoSize = true;
            Welcome.Font = new Font("MS UI Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Welcome.Location = new Point(317, 53);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(141, 19);
            Welcome.TabIndex = 1;
            Welcome.Text = "Welcome back!";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumBlue;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(293, 412);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(70, 224);
            label2.Name = "label2";
            label2.Size = new Size(142, 21);
            label2.TabIndex = 1;
            label2.Text = "Nume Proiect";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(86, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 411);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

 
        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label Welcome;
        private Label Username;
        private TextBox password_login;
        private Label label1;
        private TextBox username_login;
        private Button login;
        private CheckBox showpassword_login;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label registerclicked;
    }
}