namespace Client.UserControls
{
    partial class UCHomepage
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
            this.searchPanel = new System.Windows.Forms.Panel();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.cardsPanel = new Client.UserControls.Cards.CardsPanel();
            this.SuspendLayout();
            // 
            // searchPanel
            // 
            this.searchPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchPanel.AutoSize = true;
            this.searchPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchPanel.Location = new System.Drawing.Point(0, 0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(0, 0);
            this.searchPanel.TabIndex = 2;
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPreviousPage.Location = new System.Drawing.Point(0, 520);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(112, 29);
            this.btnPreviousPage.TabIndex = 3;
            this.btnPreviousPage.Text = "Previous Page";
            this.btnPreviousPage.UseVisualStyleBackColor = true;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNextPage.Location = new System.Drawing.Point(558, 520);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(112, 29);
            this.btnNextPage.TabIndex = 4;
            this.btnNextPage.Text = "Next Page";
            this.btnNextPage.UseVisualStyleBackColor = true;
            // 
            // cardsPanel
            // 
            this.cardsPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardsPanel.AutoSize = true;
            this.cardsPanel.BackColor = System.Drawing.Color.Transparent;
            this.cardsPanel.Location = new System.Drawing.Point(0, 207);
            this.cardsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.cardsPanel.Name = "cardsPanel";
            this.cardsPanel.Size = new System.Drawing.Size(670, 218);
            this.cardsPanel.TabIndex = 1;
            this.cardsPanel.ViewModel = null;
            // 
            // UCHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPreviousPage);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.cardsPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UCHomepage";
            this.Size = new System.Drawing.Size(670, 549);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Cards.CardsPanel cardsPanel;
        public System.Windows.Forms.Panel searchPanel;
        public System.Windows.Forms.Button btnPreviousPage;
        public System.Windows.Forms.Button btnNextPage;
    }
}
