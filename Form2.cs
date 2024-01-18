using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        string ConnectionString = "Data Source=DESKTOP-T24NJOM;Initial Catalog=LogIn;Integrated Security=True";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Display initial information when the form loads
            DisplayUserInfo();
        }

        private void DisplayUserInfo()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    // Calculate the sum of expenses
                    string expenseSumQuery = "SELECT SUM(Sales) FROM Sales";
                    using (SqlCommand sumCommand = new SqlCommand(expenseSumQuery, connection))
                    {
                        object sumResult = sumCommand.ExecuteScalar();
                        decimal totalExpense = sumResult is DBNull ? 0 : Convert.ToDecimal(sumResult);
                        lblExpenses.Text = $"Total Expenses: {totalExpense:C}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CalculateProfit()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Calculate profit (considering $100 deduction for each user)
                    string profitQuery = "SELECT (SUM(Sales)) FROM Sales";
                    using (SqlCommand profitCommand = new SqlCommand(profitQuery, connection))
                    {
                        object profitResult = profitCommand.ExecuteScalar();
                        decimal totalProfit = profitResult is DBNull ? 0 : Convert.ToDecimal(profitResult);
                        MessageBox.Show($"Total Sales: {totalProfit:C}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnCalculateExpenses_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCountUsers_Click(object sender, EventArgs e)
        {
            CountUsers();
        }


        private void CountUsers()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Count the number of users
                    string userCountQuery = "SELECT COUNT(Nume) FROM Sales";
                    using (SqlCommand countCommand = new SqlCommand(userCountQuery, connection))
                    {
                        int userCount = (int)countCommand.ExecuteScalar();
                        MessageBox.Show($"Total Users: {userCount}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnCalculateExpenses_Click_1(object sender, EventArgs e)
        {
            CalculateProfit();
        }
    }
}
