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
    public partial class BrwList : Form
    {
        string cnn = ConfigurationManager.ConnectionStrings["Data"].ConnectionString;
        public BrwList()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            using (SqlConnection brwData = new SqlConnection(cnn))
            {
                brwData.Open();
                SqlDataAdapter libAdapter = new SqlDataAdapter("SELECT * FROM BrwData", brwData);
                DataTable dt = new DataTable();
                libAdapter.Fill(dt);
                BrwView.DataSource = dt;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string criteria = txtSearch.Text;
            using (SqlConnection brwData = new SqlConnection(cnn))
            {
                brwData.Open();
                SqlDataAdapter brwAdapter = new SqlDataAdapter("SELECT * FROM BrwData WHERE Name LIKE '%" + criteria + "%' OR BorrowID LIKE '%" + criteria + "%' OR BookID LIKE '%" + criteria + "%'", brwData);
                DataTable dt = new DataTable();
                brwAdapter.Fill(dt);
                BrwView.DataSource = dt;
            }
        }

        private void BrwList_Load(object sender, EventArgs e)
        {
            using (SqlConnection brwData = new SqlConnection(cnn))
            {
                brwData.Open();
                SqlDataAdapter libAdapter = new SqlDataAdapter("SELECT * FROM BrwData", brwData);
                DataTable dt = new DataTable();
                libAdapter.Fill(dt);
                BrwView.DataSource = dt;
            }
        }
    }
}
