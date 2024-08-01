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
            this.SuspendLayout();
            // 
            // cardsPanel
            // 
            this.cardsPanel.BackColor = System.Drawing.Color.Transparent;
            this.cardsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardsPanel.Location = new System.Drawing.Point(0, 0);
            this.cardsPanel.Name = "cardsPanel";
            this.cardsPanel.Size = new System.Drawing.Size(836, 543);
            this.cardsPanel.TabIndex = 1;
            this.cardsPanel.ViewModel = null;
            // 
            // UCHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cardsPanel);
            this.Name = "UCHomepage";
            this.Size = new System.Drawing.Size(836, 543);
            this.ResumeLayout(false);

        }

        #endregion

        public Cards.CardsPanel cardsPanel;
    }
}
