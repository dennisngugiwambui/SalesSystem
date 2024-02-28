using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;



namespace SalesSystem

{
    public partial class Form1 : Form
{

    public static string? CurrentUser { get; private set; }

    //SqlDataReader sdr;
    DbConnect dbConnect = new DbConnect();
    public Form1()
    {
        InitializeComponent();
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Verify username and password and check if the user is active
            if (VerifyCredentials(username, password))
            {
                Register register = new Register();
                register.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool VerifyCredentials(string username, string password)
        {

            // Construct your SQL query to verify the credentials and check the user status
            string query = $"SELECT COUNT(*) FROM users WHERE username = '{username}' AND Password = '{password}' AND usertype = 'active'";

            DataTable result = dbConnect.ExecuteQuery(query);

            // Check if the query returned a row with a count greater than 0
            int count = Convert.ToInt32(result.Rows[0][0]);
            return count > 0;
        }

    }
}
