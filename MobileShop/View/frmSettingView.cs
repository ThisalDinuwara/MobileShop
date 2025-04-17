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
    public partial class frmSettingView : Sample
    {
        public frmSettingView()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void AddControls(Form F)
        {
            CenterPanel.Controls.Clear();
            F.TopLevel = false;
            F.Dock = DockStyle.Fill;
            CenterPanel.Controls.Add(F);
            F.Show();
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            FormUserView userView = new FormUserView();
            userView.Show();
            this.Close();
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {

        }

        private void btnColor_Click(object sender, EventArgs e)
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
    }
}
