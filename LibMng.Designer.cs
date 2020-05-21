namespace LibraryManagement
{
    partial class LibMng
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.LibView = new System.Windows.Forms.DataGridView();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.txtQuantity = new System.Windows.Forms.RichTextBox();
            this.txtAuthor = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.RichTextBox();
            this.txtBookID = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.tab3 = new System.Windows.Forms.TabPage();
            this.btnList = new System.Windows.Forms.Button();
            this.btnBrw = new System.Windows.Forms.Button();
            this.btnRtn = new System.Windows.Forms.Button();
            this.txtRtnDate = new System.Windows.Forms.TextBox();
            this.txtBrwDate = new System.Windows.Forms.TextBox();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.txtBookID2 = new System.Windows.Forms.TextBox();
            this.txtBrwID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LibView)).BeginInit();
            this.tab2.SuspendLayout();
            this.tab3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tab1);
            this.tabControl.Controls.Add(this.tab2);
            this.tabControl.Controls.Add(this.tab3);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(642, 347);
            this.tabControl.TabIndex = 0;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.label2);
            this.tab1.Controls.Add(this.txtSearch);
            this.tab1.Controls.Add(this.btnSearch);
            this.tab1.Controls.Add(this.btnRefresh);
            this.tab1.Controls.Add(this.LibView);
            this.tab1.Location = new System.Drawing.Point(4, 25);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(634, 318);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Thư viện";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter search key:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(192, 280);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(205, 22);
            this.txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(403, 270);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 42);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(517, 270);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(108, 42);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // LibView
            // 
            this.LibView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LibView.Location = new System.Drawing.Point(6, 6);
            this.LibView.Name = "LibView";
            this.LibView.RowTemplate.Height = 24;
            this.LibView.Size = new System.Drawing.Size(619, 251);
            this.LibView.TabIndex = 0;
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.txtQuantity);
            this.tab2.Controls.Add(this.txtAuthor);
            this.tab2.Controls.Add(this.txtName);
            this.tab2.Controls.Add(this.txtBookID);
            this.tab2.Controls.Add(this.label5);
            this.tab2.Controls.Add(this.label4);
            this.tab2.Controls.Add(this.label3);
            this.tab2.Controls.Add(this.label1);
            this.tab2.Controls.Add(this.btnInsert);
            this.tab2.Controls.Add(this.btnUpdate);
            this.tab2.Controls.Add(this.btnDeleteBook);
            this.tab2.Location = new System.Drawing.Point(4, 25);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(634, 318);
            this.tab2.TabIndex = 3;
            this.tab2.Text = "Quản lí sách";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(112, 144);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(225, 21);
            this.txtQuantity.TabIndex = 3;
            this.txtQuantity.Text = "";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(112, 100);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(225, 21);
            this.txtAuthor.TabIndex = 3;
            this.txtAuthor.Text = "";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(112, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(225, 21);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "";
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(112, 15);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(225, 21);
            this.txtBookID.TabIndex = 3;
            this.txtBookID.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Author(s):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "BookID:";
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(289, 270);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(108, 42);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(403, 270);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 42);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBook.Location = new System.Drawing.Point(517, 270);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(108, 42);
            this.btnDeleteBook.TabIndex = 0;
            this.btnDeleteBook.Text = "Delete";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // tab3
            // 
            this.tab3.Controls.Add(this.btnList);
            this.tab3.Controls.Add(this.btnBrw);
            this.tab3.Controls.Add(this.btnRtn);
            this.tab3.Controls.Add(this.txtRtnDate);
            this.tab3.Controls.Add(this.txtBrwDate);
            this.tab3.Controls.Add(this.txtName2);
            this.tab3.Controls.Add(this.txtBookID2);
            this.tab3.Controls.Add(this.txtBrwID);
            this.tab3.Controls.Add(this.label10);
            this.tab3.Controls.Add(this.label9);
            this.tab3.Controls.Add(this.label8);
            this.tab3.Controls.Add(this.label7);
            this.tab3.Controls.Add(this.label6);
            this.tab3.Location = new System.Drawing.Point(4, 25);
            this.tab3.Name = "tab3";
            this.tab3.Padding = new System.Windows.Forms.Padding(3);
            this.tab3.Size = new System.Drawing.Size(634, 318);
            this.tab3.TabIndex = 2;
            this.tab3.Text = "Mượn-Trả sách";
            this.tab3.UseVisualStyleBackColor = true;
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Location = new System.Drawing.Point(292, 270);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(108, 42);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnBrw
            // 
            this.btnBrw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrw.Location = new System.Drawing.Point(406, 270);
            this.btnBrw.Name = "btnBrw";
            this.btnBrw.Size = new System.Drawing.Size(108, 42);
            this.btnBrw.TabIndex = 2;
            this.btnBrw.Text = "Borrow";
            this.btnBrw.UseVisualStyleBackColor = true;
            this.btnBrw.Click += new System.EventHandler(this.btnBrw_Click);
            // 
            // btnRtn
            // 
            this.btnRtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRtn.Location = new System.Drawing.Point(520, 270);
            this.btnRtn.Name = "btnRtn";
            this.btnRtn.Size = new System.Drawing.Size(108, 42);
            this.btnRtn.TabIndex = 2;
            this.btnRtn.Text = "Return";
            this.btnRtn.UseVisualStyleBackColor = true;
            this.btnRtn.Click += new System.EventHandler(this.btnRtn_Click);
            // 
            // txtRtnDate
            // 
            this.txtRtnDate.Location = new System.Drawing.Point(162, 153);
            this.txtRtnDate.Name = "txtRtnDate";
            this.txtRtnDate.Size = new System.Drawing.Size(166, 22);
            this.txtRtnDate.TabIndex = 1;
            // 
            // txtBrwDate
            // 
            this.txtBrwDate.Location = new System.Drawing.Point(162, 119);
            this.txtBrwDate.Name = "txtBrwDate";
            this.txtBrwDate.Size = new System.Drawing.Size(166, 22);
            this.txtBrwDate.TabIndex = 1;
            // 
            // txtName2
            // 
            this.txtName2.Location = new System.Drawing.Point(162, 85);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(166, 22);
            this.txtName2.TabIndex = 1;
            // 
            // txtBookID2
            // 
            this.txtBookID2.Location = new System.Drawing.Point(162, 50);
            this.txtBookID2.Name = "txtBookID2";
            this.txtBookID2.Size = new System.Drawing.Size(166, 22);
            this.txtBookID2.TabIndex = 1;
            // 
            // txtBrwID
            // 
            this.txtBrwID.Location = new System.Drawing.Point(162, 18);
            this.txtBrwID.Name = "txtBrwID";
            this.txtBrwID.Size = new System.Drawing.Size(166, 22);
            this.txtBrwID.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Returned Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Borrowed Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "BookID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "BorrowID:";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(533, 365);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(108, 42);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // LibMng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 419);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.tabControl);
            this.Name = "LibMng";
            this.Text = "Library management";
            this.Load += new System.EventHandler(this.LibMng_Load);
            this.tabControl.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LibView)).EndInit();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            this.tab3.ResumeLayout(false);
            this.tab3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab3;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.RichTextBox txtBookID;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView LibView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtQuantity;
        private System.Windows.Forms.RichTextBox txtAuthor;
        private System.Windows.Forms.RichTextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRtnDate;
        private System.Windows.Forms.TextBox txtBrwDate;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.TextBox txtBookID2;
        private System.Windows.Forms.TextBox txtBrwID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnBrw;
        private System.Windows.Forms.Button btnRtn;
    }
}