﻿using System;
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
    public partial class Welcome : Form
    {
 
        public Welcome()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnWelcome_Click(object sender, EventArgs e)
        {
            
        }

        private void btnWelcome_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();      // Show the next form
            this.Hide();       // Optionally hide the current form
        }
    }
}
