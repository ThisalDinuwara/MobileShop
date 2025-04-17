using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShop.Model
{
    public partial class FormUserAdd : Sample
    {
        private int editID;

        public FormUserAdd()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain dashboard = new frmMain();
            dashboard.Show();
            this.Close();
        }

        private void FormUserAdd_Load(object sender, EventArgs e)
        {
            if (editID > 0)
            {
                string qry = "Select * from tblUser where userID = " + editID + "";
                DataTable dt = MainClass.GetData(qry);

                foreach (DataRow row in dt.Rows)
                {
                    txtName.Text = row["uName"].ToString();
                    txtUsername.Text = row["uUsername"].ToString();
                    txtPassword.Text = row["uPassword"].ToString();
                    txtPhone.Text = row["uPhone"].ToString();
                    txtEmail.Text = row["uEmail"].ToString();
                }
            }

        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "";
            if (editID == 0)
            {
                qry = "Insert into tblUser Values(@name,@user,@pass,@phone,@email)";
            }
            else
            {
                qry = @"Update tblUser SET uName = @name, uUsername = @user,
                    uPassword = @pass, uPhone = @phone, uEmail = @email where userID = @id";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", editID);
            ht.Add("@name", txtName.Text);
            ht.Add("@user", txtUsername.Text);
            ht.Add("@pass", txtPassword.Text);
            ht.Add("@phone", txtPhone.Text);
            ht.Add("@email", txtEmail.Text);

            if (MainClass.SQL(qry, ht) > 0)
            {
                MessageBox.Show("Saved Successfully");
                MainClass.ClearAll(this);
                editID = 0;
            }
        }
    }
}
