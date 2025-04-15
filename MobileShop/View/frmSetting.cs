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
    public partial class frmSetting : Sample
    {
        public frmSetting()
        {
            InitializeComponent();
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
            AddControls(new UserView());
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {

        }

        private void btnColor_Click(object sender, EventArgs e)
        {

        }
    }
}
