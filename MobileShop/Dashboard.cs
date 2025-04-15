using MobileShop.View;
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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        static Dashboard _obj;

        public static Dashboard Instance
        {
            get { if (_obj == null) { _obj = new Dashboard(); } return _obj; }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            _obj = this;
            btnMax.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
            MessageBox.Show("Logout Successfully");
        }

        private void btnCart_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            UserDetails user = new UserDetails();
            user.Show();
            this.Hide();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            UserDetails user = new UserDetails();
            user.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            form1.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddControls(Form F)
        {
            panel1.Controls.Clear();
            F.TopLevel = false;
            F.Dock = DockStyle.Fill;
            panel1.Controls.Add(F);
            F.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AddControls(new Dashboard());
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            AddControls(new frmSetting());
        }
    }
}
