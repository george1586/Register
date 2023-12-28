using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-IGIQ81E\SQLEXPRESS;Initial Catalog=LogInInfo;Integrated Security=True;Encrypt=True;");
        public Form1()
        {
            InitializeComponent();
        }
        private void reg_Click(object sender, EventArgs e)
        {
            SignUp sForm = new SignUp();
            sForm.Show();
            this.Hide();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string username, username_password;
            username = username_login.Text;
            username_password=password_login.Text;
            try
            {
                string connectionString = "Data Source=DESKTOP-IGIQ81E\\SQLEXPRESS;Initial Catalog=LogInInfo;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    // Use parameterized query to prevent SQL injection
                    string query = "SELECT * FROM LogIn WHERE Nume=@Username AND Parola=@Password";

                    using (SqlDataAdapter sda = new SqlDataAdapter(query, connect))
                    {
                        // Add parameters to the query
                        sda.SelectCommand.Parameters.AddWithValue("@Username", username_login.Text);
                        sda.SelectCommand.Parameters.AddWithValue("@Password", password_login.Text);

                        DataTable dtable = new DataTable();
                        sda.Fill(dtable);

                        if (dtable.Rows.Count > 0)
                        {
                            username = username_login.Text;
                            username_password = password_login.Text;
                            Form1 form2 = new Form1();
                            form2.Show();
                            this.Hide();
                            MessageBox.Show("Welcome, "+username );
                        }
                        else
                        {
                            // Handle case when no matching user is found
                            MessageBox.Show("Invalid username or password.");
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
                connect.Close();
            }
        }
    }
}