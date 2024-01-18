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
        SqlConnection cn;
        SqlDataReader dr;
        SqlCommand cmd;
        // Declari o conexiune la baza de date si comenzile pentru baza de date
      

        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=DESKTOP-T24NJOM;Initial Catalog=LogIn;Integrated Security=True");
            cn.Open();
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
            if (username_register.Text != string.Empty || password_register.Text != string.Empty || username_register.Text != string.Empty)
            {
                if (password_register.Text == reenterpassword_signup.Text)
                {
                    cmd = new SqlCommand("select * from Login where Nume='" + username_register.Text + "'", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Numele deja exista, incearca altul ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into Login values(@Nume,@Parola)", cn);
                        cmd.Parameters.AddWithValue("Nume", username_register.Text);
                        cmd.Parameters.AddWithValue("Parola", password_register.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Contul tau a fost creat. Te rog inregistreaza-te", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form1 lform= new Form1();
                        lform.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Te rog introdu parole identice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Te rog completeaza toate field-urile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
