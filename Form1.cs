using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // Declari o conexiune la baza de date
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-IGIQ81E\SQLEXPRESS;Initial Catalog=LogInInfo;Integrated Security=True;Encrypt=True;");

        public Form1()
        {
            InitializeComponent();
        }

        private void reg_Click(object sender, EventArgs e)
        {
            // Când butonul 'reg' este apăsat, deschide formularul SignUp și ascunde formularul curent
            SignUp sForm = new SignUp();
            sForm.Show();
            this.Hide();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string username, username_password;
            username = username_login.Text;
            username_password = password_login.Text;

            try
            {
                // String de conexiune pentru SQL Server
                string connectionString = "Data Source=DESKTOP-IGIQ81E\\SQLEXPRESS;Initial Catalog=LogInInfo;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

                // Utilizarea instrucțiunii 'using' pentru a asigura eliberarea corectă a resurselor
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open(); // Deschide conexiunea la bază de date

                    // Utilizarea unei interogări parametrizate pentru a preveni injectarea SQL
                    string query = "SELECT * FROM LogIn WHERE Nume=@Username AND Parola=@Password";

                    // Utilizarea SqlDataAdapter pentru a executa interogarea și a umple un DataTable
                    using (SqlDataAdapter sda = new SqlDataAdapter(query, connect))
                    {
                        // Adăugarea de parametri la interogare pentru a preveni injectarea SQL
                        sda.SelectCommand.Parameters.AddWithValue("@Username", username_login.Text);
                        sda.SelectCommand.Parameters.AddWithValue("@Password", password_login.Text);

                        // Utilizarea DataTable pentru a stoca setul de rezultate
                        using (DataTable dtable = new DataTable())
                        {
                            sda.Fill(dtable); // Umple DataTable cu setul de rezultate

                            if (dtable.Rows.Count > 0)
                            {
                                // Dacă există un utilizator corespunzător, afișează un mesaj de bun venit și navighează către un nou formular
                                username = username_login.Text;
                                username_password = password_login.Text;
                                Form1 form2 = new Form1();
                                form2.Show();
                                this.Hide();
                                MessageBox.Show("Bun venit, " + username);
                            }
                            else
                            {
                                // Gestionarea cazului în care nu se găsește niciun utilizator corespunzător
                                MessageBox.Show("Nume de utilizator sau parolă invalidă.");
                            }
                        }
                    }
                }
            }
            /*catch
            {
                MessageBox.Show("Error");
            }*/
            finally
            {
                connect.Close(); // Închide conexiunea la bază de date în blocul finally
            }
        }
        private void showpassword_login_CheckedChanged(object sender, EventArgs e)
        {
            // Schimbarea vizibilității caracterei parolei în funcție de starea casetei de bifare
            if (showpassword_login.Checked == true)
            {
                password_login.UseSystemPasswordChar = true;
            }
            if (showpassword_login.Checked == false)
            {
                password_login.UseSystemPasswordChar = false;
            }
        }
        private void password_login_TextChanged()
        {

        }
    }
}