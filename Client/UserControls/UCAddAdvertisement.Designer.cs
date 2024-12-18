﻿namespace Client.UserControls
{
    partial class UCAddAdvertisement
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMileage = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBodyType = new System.Windows.Forms.ComboBox();
            this.rbDiesel = new System.Windows.Forms.RadioButton();
            this.rbPetrol = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.checkBoxExchange = new System.Windows.Forms.CheckBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlImages = new System.Windows.Forms.Panel();
            this.btnUploadImages = new System.Windows.Forms.Button();
            this.btnResetSelection = new System.Windows.Forms.Button();
            this.btnRemoveAdvertisement = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Body Type:";
            // 
            // txtMake
            // 
            this.txtMake.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMake.Location = new System.Drawing.Point(107, 20);
            this.txtMake.Margin = new System.Windows.Forms.Padding(2);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(118, 20);
            this.txtMake.TabIndex = 3;
            // 
            // txtModel
            // 
            this.txtModel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtModel.Location = new System.Drawing.Point(107, 48);
            this.txtModel.Margin = new System.Windows.Forms.Padding(2);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(118, 20);
            this.txtModel.TabIndex = 4;
            // 
            // txtMileage
            // 
            this.txtMileage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMileage.Location = new System.Drawing.Point(107, 134);
            this.txtMileage.Margin = new System.Windows.Forms.Padding(2);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(118, 20);
            this.txtMileage.TabIndex = 10;
            this.txtMileage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMileage_KeyPress);
            // 
            // txtYear
            // 
            this.txtYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtYear.Location = new System.Drawing.Point(107, 106);
            this.txtYear.Margin = new System.Windows.Forms.Padding(2);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(118, 20);
            this.txtYear.TabIndex = 9;
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtYear_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 136);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mileage:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Year:";
            // 
            // cmbBodyType
            // 
            this.cmbBodyType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbBodyType.FormattingEnabled = true;
            this.cmbBodyType.Location = new System.Drawing.Point(107, 78);
            this.cmbBodyType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBodyType.Name = "cmbBodyType";
            this.cmbBodyType.Size = new System.Drawing.Size(118, 21);
            this.cmbBodyType.TabIndex = 12;
            // 
            // rbDiesel
            // 
            this.rbDiesel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbDiesel.AutoSize = true;
            this.rbDiesel.Location = new System.Drawing.Point(112, 166);
            this.rbDiesel.Margin = new System.Windows.Forms.Padding(2);
            this.rbDiesel.Name = "rbDiesel";
            this.rbDiesel.Size = new System.Drawing.Size(54, 17);
            this.rbDiesel.TabIndex = 13;
            this.rbDiesel.TabStop = true;
            this.rbDiesel.Text = "Diesel";
            this.rbDiesel.UseVisualStyleBackColor = true;
            // 
            // rbPetrol
            // 
            this.rbPetrol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbPetrol.AutoSize = true;
            this.rbPetrol.Location = new System.Drawing.Point(168, 166);
            this.rbPetrol.Margin = new System.Windows.Forms.Padding(2);
            this.rbPetrol.Name = "rbPetrol";
            this.rbPetrol.Size = new System.Drawing.Size(52, 17);
            this.rbPetrol.TabIndex = 14;
            this.rbPetrol.TabStop = true;
            this.rbPetrol.Text = "Petrol";
            this.rbPetrol.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 168);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Fuel:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSubmit.Location = new System.Drawing.Point(376, 482);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(103, 21);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rbPetrol);
            this.groupBox1.Controls.Add(this.rbDiesel);
            this.groupBox1.Controls.Add(this.cmbBodyType);
            this.groupBox1.Controls.Add(this.txtMileage);
            this.groupBox1.Controls.Add(this.txtYear);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Controls.Add(this.txtMake);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(65, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 200);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehicle Info";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Price (€):";
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPrice.Location = new System.Drawing.Point(399, 285);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(118, 20);
            this.txtPrice.TabIndex = 16;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrice_KeyPress);
            // 
            // checkBoxExchange
            // 
            this.checkBoxExchange.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBoxExchange.AutoSize = true;
            this.checkBoxExchange.Location = new System.Drawing.Point(399, 333);
            this.checkBoxExchange.Name = "checkBoxExchange";
            this.checkBoxExchange.Size = new System.Drawing.Size(123, 17);
            this.checkBoxExchange.TabIndex = 19;
            this.checkBoxExchange.Text = "Exchange Accepted";
            this.checkBoxExchange.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDescription.Location = new System.Drawing.Point(363, 367);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(194, 96);
            this.txtDescription.TabIndex = 20;
            this.txtDescription.Text = "";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 405);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Description:";
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(144, 483);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.pnlImages);
            this.groupBox2.Location = new System.Drawing.Point(376, 58);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(453, 166);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Uploaded Images";
            // 
            // pnlImages
            // 
            this.pnlImages.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlImages.Location = new System.Drawing.Point(2, 15);
            this.pnlImages.Margin = new System.Windows.Forms.Padding(2);
            this.pnlImages.Name = "pnlImages";
            this.pnlImages.Size = new System.Drawing.Size(449, 149);
            this.pnlImages.TabIndex = 0;
            // 
            // btnUploadImages
            // 
            this.btnUploadImages.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUploadImages.Location = new System.Drawing.Point(491, 234);
            this.btnUploadImages.Margin = new System.Windows.Forms.Padding(2);
            this.btnUploadImages.Name = "btnUploadImages";
            this.btnUploadImages.Size = new System.Drawing.Size(100, 24);
            this.btnUploadImages.TabIndex = 23;
            this.btnUploadImages.Text = "Upload Images";
            this.btnUploadImages.UseVisualStyleBackColor = true;
            // 
            // btnResetSelection
            // 
            this.btnResetSelection.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnResetSelection.Location = new System.Drawing.Point(625, 234);
            this.btnResetSelection.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetSelection.Name = "btnResetSelection";
            this.btnResetSelection.Size = new System.Drawing.Size(100, 24);
            this.btnResetSelection.TabIndex = 24;
            this.btnResetSelection.Text = "Reset Selection";
            this.btnResetSelection.UseVisualStyleBackColor = true;
            // 
            // btnRemoveAdvertisement
            // 
            this.btnRemoveAdvertisement.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRemoveAdvertisement.ForeColor = System.Drawing.Color.DarkRed;
            this.btnRemoveAdvertisement.Location = new System.Drawing.Point(2, 2);
            this.btnRemoveAdvertisement.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveAdvertisement.Name = "btnRemoveAdvertisement";
            this.btnRemoveAdvertisement.Size = new System.Drawing.Size(170, 28);
            this.btnRemoveAdvertisement.TabIndex = 26;
            this.btnRemoveAdvertisement.Text = "Remove Advertisement";
            this.btnRemoveAdvertisement.UseVisualStyleBackColor = true;
            this.btnRemoveAdvertisement.Visible = false;
            // 
            // UCAddAdvertisement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRemoveAdvertisement);
            this.Controls.Add(this.btnResetSelection);
            this.Controls.Add(this.btnUploadImages);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.checkBoxExchange);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSubmit);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCAddAdvertisement";
            this.Size = new System.Drawing.Size(892, 532);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtMake;
        public System.Windows.Forms.TextBox txtModel;
        public System.Windows.Forms.TextBox txtMileage;
        public System.Windows.Forms.TextBox txtYear;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cmbBodyType;
        public System.Windows.Forms.RadioButton rbDiesel;
        public System.Windows.Forms.RadioButton rbPetrol;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtPrice;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lblError;
        public System.Windows.Forms.RichTextBox txtDescription;
        public System.Windows.Forms.CheckBox checkBoxExchange;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button btnUploadImages;
        public System.Windows.Forms.Panel pnlImages;
        public System.Windows.Forms.Button btnResetSelection;
        public System.Windows.Forms.Button btnRemoveAdvertisement;
    }
}
