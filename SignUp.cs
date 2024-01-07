using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class SignUp : Form
    {
        // Declari o conexiune la baza de date
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-IGIQ81E\SQLEXPRESS;Initial Catalog=LogInInfo;Integrated Security=True;Encrypt=True");

        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            // Aici poți adăuga logica necesară la încărcarea formularului SignUp
        }

        private void log_Click(object sender, EventArgs e)
        {
            // Când butonul 'log' este apăsat, deschide formularul Form1 și ascunde formularul curent
            Form1 lForm = new Form1();
            lForm.Show();
            this.Hide();
        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            // Aici poți adăuga logica necesară pentru gestionarea evenimentului de apăsare a butonului de înregistrare
        }

        private void showpassword_register_CheckedChanged(object sender, EventArgs e)
        {
            // Schimbarea vizibilității caracterei parolei în funcție de starea casetei de bifare
            if (showpassword_register.Checked == true)
            {
                password_register.UseSystemPasswordChar = true;
                reenterpassword_signup.UseSystemPasswordChar = true;
            }
            if (showpassword_register.Checked == false)
            {
                password_register.UseSystemPasswordChar = false;
                reenterpassword_signup.UseSystemPasswordChar = false;
            }
        }

    }
}
