using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShop.View
{
    public partial class FormUserView : Sample
    {
        public FormUserView()
        {
            InitializeComponent();
        }

        private void FormUserViem_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string qry = @"select 0 'Sr' , userID , uName,uPass,uPhone,uEmail from tblUser where uName like
                                   '%"+txtSearch.Text+"%'";
            MainClass.LoadData(qry, guna2DataGridView1);
        }

        private void Guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

        }

        private void Guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new FormUserView());
            LoadData();
        }

        public void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        public void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[1].ToString());
            MainClass.BlurBackground(new FormUserView() { });
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
