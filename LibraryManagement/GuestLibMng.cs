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
    public partial class GuestLibMng : Form
    {
        string cnn = ConfigurationManager.ConnectionStrings["Data"].ConnectionString;
        public GuestLibMng()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();         
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            using (SqlConnection libData = new SqlConnection(cnn)) 
            {
                libData.Open();
                SqlDataAdapter libAdapter = new SqlDataAdapter("SELECT * FROM LibData", libData);
                DataTable dt = new DataTable();
                libAdapter.Fill(dt);
                GuestView.DataSource = dt;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string criteria = txtSearch.Text;
            using (SqlConnection libData = new SqlConnection(cnn))
            {
                libData.Open();
                SqlDataAdapter libAdapter = new SqlDataAdapter("SELECT * FROM LibData WHERE Name LIKE '%" + criteria + "%' OR [Author(s)] LIKE '%" + criteria + "%' OR BookID LIKE '%" + criteria + "%'", libData);
                DataTable dt = new DataTable();
                libAdapter.Fill(dt);
                GuestView.DataSource = dt;
            }
        }

        private void GuestLibMng_Load(object sender, EventArgs e)
        {
            using (SqlConnection libData = new SqlConnection(cnn))
            {
                libData.Open();
                SqlDataAdapter libAdapter = new SqlDataAdapter("SELECT * FROM LibData", libData);
                DataTable dt = new DataTable();
                libAdapter.Fill(dt);
                GuestView.DataSource = dt;
            }
        }
    }
}
