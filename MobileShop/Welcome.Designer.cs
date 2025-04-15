namespace MobileShop
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.btnWelcome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWelcome
            // 
            this.btnWelcome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWelcome.BackgroundImage")));
            this.btnWelcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWelcome.Location = new System.Drawing.Point(-35, -52);
            this.btnWelcome.Name = "btnWelcome";
            this.btnWelcome.Size = new System.Drawing.Size(873, 550);
            this.btnWelcome.TabIndex = 0;
            this.btnWelcome.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnWelcome.UseVisualStyleBackColor = true;
            this.btnWelcome.Click += new System.EventHandler(this.btnWelcome_Click_1);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWelcome;
    }
}