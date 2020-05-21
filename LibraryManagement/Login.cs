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
using System.Configuration;

namespace LibraryManagement
{
    public partial class Login : Form
    {
        string cnn = ConfigurationManager.ConnectionStrings["Data"].ConnectionString;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(cnn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select Count(*) from LOGIN where USERNAME='" + txtUser.Text + "' and PASSWORD='" + txtPass.Text + "'", connect);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();              
                using (LibMng libManage = new LibMng())
                    libManage.ShowDialog();
                txtPass.Text = txtPass.Text.Remove(0,txtPass.Text.Length);
                txtUser.Text = txtUser.Text.Remove(0,txtUser.Text.Length);
                this.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (GuestLibMng GuestLib = new GuestLibMng())
                GuestLib.ShowDialog();
            txtPass.Text = txtPass.Text.Remove(0, txtPass.Text.Length);
            txtUser.Text = txtUser.Text.Remove(0, txtUser.Text.Length);
            this.Show();
        }
    }
}