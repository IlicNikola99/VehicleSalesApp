using Client.GuiController;
using Client.UserControls;
using Common.Domain;

namespace Client
{
    partial class FrmMain
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
            this.mnMain = new System.Windows.Forms.MenuStrip();
            this.itemHome = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAddAdvertisement = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUser = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.mnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnMain
            // 
            this.mnMain.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemHome,
            this.itemAddAdvertisement});
            this.mnMain.Location = new System.Drawing.Point(0, 0);
            this.mnMain.Name = "mnMain";
            this.mnMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mnMain.Size = new System.Drawing.Size(1392, 33);
            this.mnMain.TabIndex = 0;
            this.mnMain.Text = "menuStrip1";
            // 
            // itemHome
            // 
            this.itemHome.Name = "itemHome";
            this.itemHome.Size = new System.Drawing.Size(77, 29);
            this.itemHome.Text = "Home";
            // 
            // itemAddAdvertisement
            // 
            this.itemAddAdvertisement.Name = "itemAddAdvertisement";
            this.itemAddAdvertisement.Size = new System.Drawing.Size(182, 29);
            this.itemAddAdvertisement.Text = "Add Advertisement";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(38, 121);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 20);
            this.lblUser.TabIndex = 1;
            // 
            // pnlMain
            // 
            this.pnlMain.AutoSize = true;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 33);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1392, 634);
            this.pnlMain.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 667);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.mnMain);
            this.MainMenuStrip = this.mnMain;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            User loggedInUser = LoginGuiController.Instance.LoggedInUser;
            if (loggedInUser != null)
            {
                this.Text = "Welcome " + loggedInUser.FirstName + " " + loggedInUser.LastName;
            }
            else this.Text = "Welcome";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.mnMain.ResumeLayout(false);
            this.mnMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnMain;
        private System.Windows.Forms.ToolStripMenuItem itemAddAdvertisement;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel pnlMain;
        public System.Windows.Forms.ToolStripMenuItem itemHome;
    }
}