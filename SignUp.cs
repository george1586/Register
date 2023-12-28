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
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-IGIQ81E\SQLEXPRESS;Initial Catalog=LogInInfo;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        public SignUp()
        {
            InitializeComponent();
        }
        private void SignUp_Load(object sender, EventArgs e)
        {

        }
        private void log_Click(object sender, EventArgs e)
        {
            Form1 lForm = new Form1();
            lForm.Show();
            this.Hide();
        }

        private void signup_button_Click(object sender, EventArgs e)
        {

        }
    }
}
