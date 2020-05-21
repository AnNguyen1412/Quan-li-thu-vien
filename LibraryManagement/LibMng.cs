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
    public partial class LibMng : Form
    {
        string cnn = ConfigurationManager.ConnectionStrings["Data"].ConnectionString;
        public LibMng()
        {
            InitializeComponent();
        }
        private void clearTxt()
        {
            //xóa hết kí tự trong tab LibMng-Muon tra
            txtBrwID.Text = "";
            txtBookID2.Text = "";
            txtName2.Text = "";
            txtBrwDate.Text = "";
            txtRtnDate.Text = "";
            //xóa hết kí tự trong tab LibMng-QuanLy
            txtBookID.Text = "";
            txtName.Text = "";
            txtAuthor.Text = "";
            txtQuantity.Text="";
        }
        //LibMng-All
        private void LibMng_Load(object sender, EventArgs e)
        {
            using (SqlConnection libData = new SqlConnection(cnn))
            {
                libData.Open();
                SqlDataAdapter libAdapter = new SqlDataAdapter("SELECT * FROM LibData", libData);
                DataTable dt = new DataTable();
                libAdapter.Fill(dt);
                LibView.DataSource = dt;
            }
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //LibMng-Thu vien
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            using (SqlConnection libData = new SqlConnection(cnn))
            {
                libData.Open();
                SqlDataAdapter libAdapter = new SqlDataAdapter("SELECT * FROM LibData", libData);
                DataTable dt = new DataTable();
                libAdapter.Fill(dt);
                LibView.DataSource = dt;
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
                LibView.DataSource = dt;
            }
        }
        //LibMng-Quan li
        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (!(txtBookID.Text == string.Empty))
            {
                SqlConnection connect = new SqlConnection(cnn);
                SqlCommand command = new SqlCommand("delete from LibData where BookID ='" + this.txtBookID.Text + "'", connect);
                SqlCommand cmd_Brw = new SqlCommand("delete from BrwData where BookID ='" + this.txtBookID.Text + "'", connect);
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select Count(*) from LibData where BookID =' " + this.txtBookID.Text + "'", connect);
                DataTable dt = new DataTable();
                try
                {
                    dataAdapter.Fill(dt);
                }
                catch (Exception)
                {
                    MessageBox.Show("BookID only accepts number only");
                    return;
                }

                SqlDataReader myreader, brwreader;
                if (dt.Rows[0][0].ToString() != "0")
                {
                    try
                    {
                        connect.Open();
                        brwreader = cmd_Brw.ExecuteReader();
                        brwreader.Close();
                        myreader = command.ExecuteReader();
                        MessageBox.Show("Deleted", "Library Infomation");
                        clearTxt();
                        while (myreader.Read())
                        {
                        }
                        connect.Close();
                    }
                    catch (Exception ec)
                    {
                        MessageBox.Show(ec.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Wrong BookID, please check your BookID", "Library Infomation");
                }
            }
            else
            {
                MessageBox.Show("Please enter BookID", "Library Information");
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection libData = new SqlConnection(cnn))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select Count(*) from [dbo].[LibData] where BookID='" + txtBookID.Text + "'", libData);
                DataTable dt = new DataTable();
                try
                {
                    dataAdapter.Fill(dt);
                }
                catch (Exception)
                {
                    MessageBox.Show("BookID only accepts number only");
                    return;
                }
                if (dt.Rows[0][0].ToString() == "1")
                {
                    libData.Open();
                    if (txtName.Text != "")
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE [dbo].[LibData] SET [Name] = '" + txtName.Text + "'  WHERE [BookId] = '" + txtBookID.Text + "'", libData);
                        cmd.ExecuteNonQuery();
                    }
                    if (txtAuthor.Text != "")
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE [dbo].[LibData] SET [Author(s)] = '" + txtAuthor.Text + "' WHERE [BookId] = '" + txtBookID.Text + "'", libData);
                        cmd.ExecuteNonQuery();
                    }
                    try
                    {
                        if (txtQuantity.Text != "")
                        {
                            SqlCommand cmd = new SqlCommand("UPDATE [dbo].[LibData] SET Quantity = '" + txtQuantity.Text + "' WHERE [BookId] = '" + txtBookID.Text + "'", libData);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Quantity only accepts number only");
                        return;
                    }
                    
                    libData.Close();                   
                    MessageBox.Show("Update Sucessfully", "Library Information");
                    clearTxt();
                }
                else
                {
                    MessageBox.Show("Update Unsucessfully, no BookID was found", "Library Information");
                }
            }
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (SqlConnection libData = new SqlConnection(cnn))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[LibData] (
                    [BookID]
                    ,[Name]
                    ,[Author(s)]
                    ,[Quantity])
                    VALUES
                        ('" + txtBookID.Text + "','" + txtName.Text + "', '" + txtAuthor.Text + "', '" + txtQuantity.Text + "')", libData);
                    libData.Open();
                    cmd.ExecuteNonQuery();
                    libData.Close();
                    MessageBox.Show("Insert Sucessfully", "Library Information");
                    clearTxt();
                }
                catch (Exception)
                {
                    MessageBox.Show("Insert Unsucessfully, Please check your input", "Library Information");
                }
            }
        }
        //LibMng-Muon-Tra
        private void btnList_Click(object sender, EventArgs e)
        {
            using (BrwList list = new BrwList())
                list.ShowDialog();
        }
        private void btnBrw_Click(object sender, EventArgs e)
        {
            using (SqlConnection libData = new SqlConnection(cnn))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select Count(*) from LibData where BookID =' " + this.txtBookID2.Text + "' AND Quantity > '" + 0 + "'", libData);
                DataTable dt = new DataTable();
                try
                {
                    dataAdapter.Fill(dt);
                }
                catch (Exception)
                {
                    MessageBox.Show("BookID and BorrowID only accept number only");
                    return;
                }
                if (dt.Rows[0][0].ToString() != "0")
                {                 
                    try
                    {
                        SqlCommand cmd;
                        if (String.IsNullOrEmpty(txtBrwDate.Text) && String.IsNullOrEmpty(txtRtnDate.Text))
                        {
                            cmd = new SqlCommand(@"INSERT INTO [dbo].[BrwData] ( [BookID],[BorrowID],[Name],[Borrwed Date],[Return Date]) VALUES ('" + txtBookID2.Text + "','" + txtBrwID.Text + "','" + txtName2.Text + "', (GETDATE()), (GETDATE()+7))", libData);                           
                        }
                        else if (!String.IsNullOrEmpty(txtBrwDate.Text) && String.IsNullOrEmpty(txtRtnDate.Text))
                        {
                            cmd = new SqlCommand(@"INSERT INTO [dbo].[BrwData] ( [BookID],[BorrowID],[Name],[Borrwed Date]) VALUES ('" + txtBookID2.Text + "','" + txtBrwID.Text + "','" + txtName2.Text + "', '" + txtBrwDate.Text + "')", libData);
                        }
                        else if (String.IsNullOrEmpty(txtBrwDate.Text) && !String.IsNullOrEmpty(txtRtnDate.Text))
                        {
                            cmd = new SqlCommand(@"INSERT INTO [dbo].[BrwData] ( [BookID],[BorrowID],[Name],[Return Date]) VALUES ('" + txtBookID2.Text + "','" + txtBrwID.Text + "','" + txtName2.Text + "', '" + txtRtnDate.Text + "')", libData);
                        }
                        else
                        {
                            cmd = new SqlCommand(@"INSERT INTO [dbo].[BrwData] ( [BookID],[BorrowID],[Name],[Borrwed Date],[Return Date]) VALUES ('" + txtBookID2.Text + "','" + txtBrwID.Text + "','" + txtName2.Text + "', '" + txtBrwDate.Text + "', '" + txtRtnDate.Text + "')", libData);
                        }
                        SqlCommand cmd_update = new SqlCommand("UPDATE [dbo].[LibData] SET Quantity = Quantity - 1 WHERE [BookId] = '" + txtBookID2.Text + "'", libData);
                        libData.Open();
                        cmd.ExecuteNonQuery();
                        cmd_update.ExecuteNonQuery();
                        MessageBox.Show("Borrow Sucessfully", "Library Information");
                        clearTxt();
                        libData.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Borrow Unsucessfully, Please check your input", "Library Information");
                    }
                }
                else
                {
                    MessageBox.Show("Please check BookID and Quantity of the book you are asking for", "Library Infomation");
                }
            }
        }
    }
  }
