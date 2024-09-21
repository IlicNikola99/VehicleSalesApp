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
            this.cardsPanel = new Client.UserControls.Cards.CardsPanel();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cardsPanel
            // 
            this.cardsPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardsPanel.AutoSize = true;
            this.cardsPanel.BackColor = System.Drawing.Color.Transparent;
            this.cardsPanel.Location = new System.Drawing.Point(0, 319);
            this.cardsPanel.Name = "cardsPanel";
            this.cardsPanel.Size = new System.Drawing.Size(1005, 335);
            this.cardsPanel.TabIndex = 1;
            this.cardsPanel.ViewModel = null;
            // 
            // searchPanel
            // 
            this.searchPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchPanel.AutoSize = true;
            this.searchPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchPanel.Location = new System.Drawing.Point(0, 0);
            this.searchPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(0, 0);
            this.searchPanel.TabIndex = 2;
            // 
            // UCHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.cardsPanel);
            this.Name = "UCHomepage";
            this.Size = new System.Drawing.Size(1005, 654);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Cards.CardsPanel cardsPanel;
        public System.Windows.Forms.Panel searchPanel;
    }
}
