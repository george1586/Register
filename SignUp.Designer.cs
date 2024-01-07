namespace WinFormsApp1
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            showpassword_register = new CheckBox();
            signup_button = new Button();
            password_register = new TextBox();
            label1 = new Label();
            username_register = new TextBox();
            Username = new Label();
            Welcome = new Label();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            reenterpassword_signup = new TextBox();
            label4 = new Label();
            label3 = new Label();
            login = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // showpassword_register
            // 
            showpassword_register.AutoSize = true;
            showpassword_register.BackColor = Color.White;
            showpassword_register.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            showpassword_register.ForeColor = Color.Gray;
            showpassword_register.Location = new Point(507, 291);
            showpassword_register.Name = "showpassword_register";
            showpassword_register.RightToLeft = RightToLeft.Yes;
            showpassword_register.Size = new Size(102, 17);
            showpassword_register.TabIndex = 18;
            showpassword_register.Text = "Show Password";
            showpassword_register.TextAlign = ContentAlignment.TopLeft;
            showpassword_register.UseVisualStyleBackColor = false;
            showpassword_register.CheckedChanged += showpassword_register_CheckedChanged;
            // 
            // signup_button
            // 
            signup_button.BackColor = Color.MediumBlue;
            signup_button.Cursor = Cursors.Hand;
            signup_button.FlatAppearance.BorderSize = 0;
            signup_button.FlatStyle = FlatStyle.Flat;
            signup_button.ForeColor = Color.White;
            signup_button.Location = new Point(320, 316);
            signup_button.Name = "signup_button";
            signup_button.Size = new Size(128, 43);
            signup_button.TabIndex = 17;
            signup_button.Text = "SIGN UP";
            signup_button.UseVisualStyleBackColor = false;
            signup_button.Click += signup_button_Click;
            // 
            // password_register
            // 
            password_register.Location = new Point(317, 198);
            password_register.MaxLength = 30;
            password_register.Multiline = true;
            password_register.Name = "password_register";
            password_register.PasswordChar = '*';
            password_register.Size = new Size(292, 33);
            password_register.TabIndex = 16;
            password_register.TextChanged += password_register_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(317, 180);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 15;
            label1.Text = "Password";
            // 
            // username_register
            // 
            username_register.Location = new Point(317, 144);
            username_register.MaxLength = 30;
            username_register.Multiline = true;
            username_register.Name = "username_register";
            username_register.Size = new Size(292, 33);
            username_register.TabIndex = 14;
            username_register.TextChanged += username_register_TextChanged;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(317, 125);
            Username.Name = "Username";
            Username.Size = new Size(60, 15);
            Username.TabIndex = 13;
            Username.Text = "Username";
            // 
            // Welcome
            // 
            Welcome.AutoSize = true;
            Welcome.Font = new Font("MS UI Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Welcome.Location = new Point(317, 53);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(119, 19);
            Welcome.TabIndex = 12;
            Welcome.Text = "Get started!";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumBlue;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(293, 412);
            panel2.TabIndex = 11;
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
            // reenterpassword_signup
            // 
            reenterpassword_signup.Location = new Point(317, 252);
            reenterpassword_signup.MaxLength = 30;
            reenterpassword_signup.Multiline = true;
            reenterpassword_signup.Name = "reenterpassword_signup";
            reenterpassword_signup.PasswordChar = '*';
            reenterpassword_signup.Size = new Size(292, 33);
            reenterpassword_signup.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(317, 234);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 21;
            label4.Text = "Reenter Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(320, 377);
            label3.Name = "label3";
            label3.Size = new Size(142, 15);
            label3.TabIndex = 23;
            label3.Text = "Already have an account?";
            // 
            // login
            // 
            login.AutoSize = true;
            login.Cursor = Cursors.Hand;
            login.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Underline, GraphicsUnit.Point);
            login.ForeColor = Color.RoyalBlue;
            login.Location = new Point(472, 377);
            login.Name = "login";
            login.Size = new Size(70, 16);
            login.TabIndex = 24;
            login.Text = "LogIn here";
            login.Click += log_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(639, 412);
            Controls.Add(login);
            Controls.Add(label3);
            Controls.Add(reenterpassword_signup);
            Controls.Add(label4);
            Controls.Add(showpassword_register);
            Controls.Add(signup_button);
            Controls.Add(password_register);
            Controls.Add(label1);
            Controls.Add(username_register);
            Controls.Add(Username);
            Controls.Add(Welcome);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            Load += SignUp_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void password_register_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void username_register_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private CheckBox showpassword_register;
        private Button signup_button;
        private TextBox password_register;
        private Label label1;
        private TextBox username_register;
        private Label Username;
        private Label Welcome;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox reenterpassword_signup;
        private Label label4;
        private Label label3;
        private Label login;
    }
}