using MobileShop.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShop
{
    public partial class SampleView : Sample
    {
        public SampleView()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public virtual void btnAdd_Click(object sender, EventArgs e)
        {
            FormUserAdd user = new FormUserAdd();
            user.Show();
            this.Hide();
            LoadData();
        }

        private void LoadData()
        {
            throw new NotImplementedException();
        }

        public virtual void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public virtual void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
