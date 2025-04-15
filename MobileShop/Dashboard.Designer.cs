namespace MobileShop
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDashbord = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMin = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMax = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2ImageButton5 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton4 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnBrands = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnCart = new Guna.UI2.WinForms.Guna2Button();
            this.btnPOS = new Guna.UI2.WinForms.Guna2Button();
            this.btnStocks = new Guna.UI2.WinForms.Guna2Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dashboard";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(241, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(903, 48);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(748, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Home/Dashboard";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDashbord
            // 
            this.lblDashbord.AutoSize = true;
            this.lblDashbord.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashbord.ForeColor = System.Drawing.Color.Black;
            this.lblDashbord.Location = new System.Drawing.Point(28, 14);
            this.lblDashbord.Name = "lblDashbord";
            this.lblDashbord.Size = new System.Drawing.Size(198, 25);
            this.lblDashbord.TabIndex = 2;
            this.lblDashbord.Text = "Admin DashBoard";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button1.Location = new System.Drawing.Point(251, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 46);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Controls.Add(this.btnMax);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblDashbord);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 53);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMin.FillColor = System.Drawing.Color.Transparent;
            this.btnMin.IconColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(1002, 9);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(42, 39);
            this.btnMin.TabIndex = 17;
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.btnMax.FillColor = System.Drawing.Color.Transparent;
            this.btnMax.IconColor = System.Drawing.Color.White;
            this.btnMax.Location = new System.Drawing.Point(1050, 9);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(42, 39);
            this.btnMax.TabIndex = 16;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.BorderColor = System.Drawing.Color.Brown;
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1098, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 37);
            this.btnExit.TabIndex = 16;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.guna2ImageButton5);
            this.panel2.Controls.Add(this.guna2ImageButton4);
            this.panel2.Controls.Add(this.guna2ImageButton3);
            this.panel2.Controls.Add(this.guna2ImageButton2);
            this.panel2.Controls.Add(this.guna2ImageButton1);
            this.panel2.Controls.Add(this.btnUser);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnSetting);
            this.panel2.Controls.Add(this.btnBrands);
            this.panel2.Controls.Add(this.btnDashboard);
            this.panel2.Location = new System.Drawing.Point(-1, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 567);
            this.panel2.TabIndex = 1;
            // 
            // guna2ImageButton5
            // 
            this.guna2ImageButton5.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton5.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton5.Image")));
            this.guna2ImageButton5.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton5.ImageRotate = 0F;
            this.guna2ImageButton5.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton5.Location = new System.Drawing.Point(12, 312);
            this.guna2ImageButton5.Name = "guna2ImageButton5";
            this.guna2ImageButton5.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton5.Size = new System.Drawing.Size(42, 39);
            this.guna2ImageButton5.TabIndex = 17;
            // 
            // guna2ImageButton4
            // 
            this.guna2ImageButton4.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton4.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton4.Image")));
            this.guna2ImageButton4.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton4.ImageRotate = 0F;
            this.guna2ImageButton4.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton4.Location = new System.Drawing.Point(12, 243);
            this.guna2ImageButton4.Name = "guna2ImageButton4";
            this.guna2ImageButton4.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton4.Size = new System.Drawing.Size(42, 39);
            this.guna2ImageButton4.TabIndex = 16;
            // 
            // guna2ImageButton3
            // 
            this.guna2ImageButton3.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton3.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton3.Image")));
            this.guna2ImageButton3.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton3.ImageRotate = 0F;
            this.guna2ImageButton3.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ImageButton3.Location = new System.Drawing.Point(12, 177);
            this.guna2ImageButton3.Name = "guna2ImageButton3";
            this.guna2ImageButton3.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton3.Size = new System.Drawing.Size(42, 39);
            this.guna2ImageButton3.TabIndex = 15;
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton2.Location = new System.Drawing.Point(12, 108);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.Size = new System.Drawing.Size(42, 39);
            this.guna2ImageButton2.TabIndex = 14;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Location = new System.Drawing.Point(12, 51);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(42, 39);
            this.guna2ImageButton1.TabIndex = 13;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnUser.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Location = new System.Drawing.Point(64, 117);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(135, 30);
            this.btnUser.TabIndex = 11;
            this.btnUser.Text = "User";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(64, 312);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(135, 37);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSetting.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Location = new System.Drawing.Point(64, 243);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(135, 37);
            this.btnSetting.TabIndex = 7;
            this.btnSetting.Text = "Settings";
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnBrands
            // 
            this.btnBrands.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBrands.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnBrands.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrands.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrands.ForeColor = System.Drawing.Color.White;
            this.btnBrands.Location = new System.Drawing.Point(64, 177);
            this.btnBrands.Name = "btnBrands";
            this.btnBrands.Size = new System.Drawing.Size(135, 30);
            this.btnBrands.TabIndex = 5;
            this.btnBrands.Text = "Brands";
            this.btnBrands.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(64, 51);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(135, 30);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnCart
            // 
            this.btnCart.BorderRadius = 15;
            this.btnCart.CustomBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCart.CustomBorderThickness = new System.Windows.Forms.Padding(5);
            this.btnCart.DisabledState.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCart.DisabledState.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCart.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnCart.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.btnCart.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCart.Image = ((System.Drawing.Image)(resources.GetObject("btnCart.Image")));
            this.btnCart.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCart.ImageOffset = new System.Drawing.Point(0, 25);
            this.btnCart.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCart.IndicateFocus = true;
            this.btnCart.Location = new System.Drawing.Point(293, 133);
            this.btnCart.Name = "btnCart";
            this.btnCart.PressedColor = System.Drawing.Color.BurlyWood;
            this.btnCart.ShadowDecoration.Color = System.Drawing.Color.MidnightBlue;
            this.btnCart.Size = new System.Drawing.Size(224, 75);
            this.btnCart.TabIndex = 13;
            this.btnCart.Text = "Cart";
            this.btnCart.TextOffset = new System.Drawing.Point(0, -25);
            this.btnCart.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnCart.Tile = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPOS.BorderRadius = 15;
            this.btnPOS.BorderThickness = 5;
            this.btnPOS.CheckedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPOS.CheckedState.CustomBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPOS.CheckedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnPOS.CustomBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPOS.CustomBorderThickness = new System.Windows.Forms.Padding(5);
            this.btnPOS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPOS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPOS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPOS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPOS.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnPOS.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.btnPOS.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnPOS.Image = ((System.Drawing.Image)(resources.GetObject("btnPOS.Image")));
            this.btnPOS.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPOS.ImageOffset = new System.Drawing.Point(0, 25);
            this.btnPOS.ImageSize = new System.Drawing.Size(40, 40);
            this.btnPOS.IndicateFocus = true;
            this.btnPOS.Location = new System.Drawing.Point(568, 133);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.PressedColor = System.Drawing.Color.BurlyWood;
            this.btnPOS.ShadowDecoration.Color = System.Drawing.Color.MidnightBlue;
            this.btnPOS.Size = new System.Drawing.Size(224, 75);
            this.btnPOS.TabIndex = 14;
            this.btnPOS.Text = "POS";
            this.btnPOS.TextOffset = new System.Drawing.Point(0, -25);
            this.btnPOS.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnPOS.Tile = true;
            // 
            // btnStocks
            // 
            this.btnStocks.BorderRadius = 15;
            this.btnStocks.CustomBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnStocks.CustomBorderThickness = new System.Windows.Forms.Padding(5);
            this.btnStocks.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStocks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStocks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStocks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStocks.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnStocks.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.btnStocks.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnStocks.Image = ((System.Drawing.Image)(resources.GetObject("btnStocks.Image")));
            this.btnStocks.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStocks.ImageOffset = new System.Drawing.Point(0, 35);
            this.btnStocks.ImageSize = new System.Drawing.Size(60, 60);
            this.btnStocks.IndicateFocus = true;
            this.btnStocks.Location = new System.Drawing.Point(848, 133);
            this.btnStocks.Name = "btnStocks";
            this.btnStocks.PressedColor = System.Drawing.Color.BurlyWood;
            this.btnStocks.ShadowDecoration.Color = System.Drawing.Color.MidnightBlue;
            this.btnStocks.Size = new System.Drawing.Size(224, 75);
            this.btnStocks.TabIndex = 15;
            this.btnStocks.Text = "Stocks";
            this.btnStocks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnStocks.TextOffset = new System.Drawing.Point(0, -35);
            this.btnStocks.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnStocks.Tile = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1143, 576);
            this.Controls.Add(this.btnStocks);
            this.Controls.Add(this.btnPOS);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDashbord;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnBrands;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUser;
        private Guna.UI2.WinForms.Guna2Button btnCart;
        private Guna.UI2.WinForms.Guna2Button btnPOS;
        private Guna.UI2.WinForms.Guna2Button btnStocks;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton5;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton4;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ControlBox btnMin;
        private Guna.UI2.WinForms.Guna2ControlBox btnMax;
        private Guna.UI2.WinForms.Guna2ControlBox btnExit;
    }
}