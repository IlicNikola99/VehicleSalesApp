namespace Client.UserControls.Cards
{
    partial class UCCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMakeModel = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMakeModel
            // 
            this.lblMakeModel.AutoSize = true;
            this.lblMakeModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMakeModel.Location = new System.Drawing.Point(2, 94);
            this.lblMakeModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMakeModel.Name = "lblMakeModel";
            this.lblMakeModel.Size = new System.Drawing.Size(92, 16);
            this.lblMakeModel.TabIndex = 0;
            this.lblMakeModel.Text = "Make Model";
            this.lblMakeModel.Click += new System.EventHandler(this.UCCard_Click);
            this.lblMakeModel.MouseEnter += new System.EventHandler(this.UCCard_MouseHover);
            this.lblMakeModel.MouseLeave += new System.EventHandler(this.UCCard_MouseLeave);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(2, 113);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 19);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price";
            this.lblPrice.Click += new System.EventHandler(this.UCCard_Click);
            this.lblPrice.MouseEnter += new System.EventHandler(this.UCCard_MouseHover);
            this.lblPrice.MouseLeave += new System.EventHandler(this.UCCard_MouseLeave);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(88, 113);
            this.lblYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(38, 19);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Year";
            this.lblYear.Click += new System.EventHandler(this.UCCard_Click);
            this.lblYear.MouseEnter += new System.EventHandler(this.UCCard_MouseHover);
            this.lblYear.MouseLeave += new System.EventHandler(this.UCCard_MouseLeave);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(127, 92);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.UCCard_Click);
            this.pictureBox.MouseEnter += new System.EventHandler(this.UCCard_MouseHover);
            this.pictureBox.MouseLeave += new System.EventHandler(this.UCCard_MouseLeave);
            // 
            // UCCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblMakeModel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCCard";
            this.Size = new System.Drawing.Size(127, 135);
            this.Click += new System.EventHandler(this.UCCard_Click);
            this.MouseLeave += new System.EventHandler(this.UCCard_MouseLeave);
            this.MouseHover += new System.EventHandler(this.UCCard_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblMakeModel;
        public System.Windows.Forms.Label lblPrice;
        public System.Windows.Forms.Label lblYear;
        public System.Windows.Forms.PictureBox pictureBox;
    }
}
