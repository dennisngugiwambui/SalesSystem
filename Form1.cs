using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Data.Common;
using Tulpep.NotificationWindow;



namespace SalesSystem

{
    public partial class Form1 : Form
    {

        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        //DbConnect dbconn = new DbConnect();
        public string _pass, _username = "";
        public bool _isActive = false;

        //public static string? CurrentUser { get; private set; }

        //SqlDataReader sdr;
        //DbConnect dbConnect = new DbConnect();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = "Data Source=DESKTOP-SEM7QMC\\SQLEXPRESS;Initial Catalog=poultryManagement;Persist Security Info=True;User ID=smartenduser;Password=l0l0t1ng@2209;TrustServerCertificate=True;";

            string _usertype = "", _name = "";
            try
            {
                bool found = false;
                conn.Open();
                string sql = "SELECT * FROM users WHERE name=@username AND password=@password";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    found = true;
                    _username = dr["name"].ToString();
                    _usertype = dr["usertype"].ToString(); // Assuming 'role' is 'usertype'
                    _name = dr["name"].ToString();
                    _pass = dr["password"].ToString();
                    string status = dr["status"].ToString(); // Assuming 'isactive' is 'status'
                    _isActive = (status.ToLower() == "active");
                }

                dr.Close();
                conn.Close();

                if (found)
                {
                    if (!_isActive)
                    {
                        MessageBox.Show("Account is deactivated. Unable to login", "Inactivate Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (_usertype == "farmer")
                    {
                        //MessageBox.Show("Access Granted! Welcome " + _name, "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        PopupNotifier popupNotifier = new PopupNotifier();
                        popupNotifier.Image = Properties.Resources.success;
                        popupNotifier.TitleText = "Access Granted";
                        popupNotifier.ContentText = "Welcome " + _name + " ACCESS GRANTED";
                        popupNotifier.Popup();

                        txtPassword.Clear();
                        txtUsername.Clear();
                        Hide();

                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Access Granted! Welcome " + _name, "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPassword.Clear();
                        txtUsername.Clear();
                        Hide();
                        Register frm = new Register();
                        frm.Show();
                    }
                }
                else
                {
                    // MessageBox.Show("Invalid Username or Password", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    PopupNotifier popupNotifier = new PopupNotifier();
                    popupNotifier.Image = Properties.Resources.error;
                    popupNotifier.TitleText = "ACCESS DENIED";
                    popupNotifier.ContentText = "Invalid Username or Password";
                    popupNotifier.Popup();
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();

            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
