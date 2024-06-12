namespace Client.UserControls
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Body Type:";
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(221, 64);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(175, 26);
            this.txtMake.TabIndex = 3;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(221, 107);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(175, 26);
            this.txtModel.TabIndex = 4;
            // 
            // txtMileage
            // 
            this.txtMileage.Location = new System.Drawing.Point(221, 240);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(175, 26);
            this.txtMileage.TabIndex = 10;
            this.txtMileage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMileage_KeyPress);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(221, 197);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(175, 26);
            this.txtYear.TabIndex = 9;
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtYear_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mileage:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Year:";
            // 
            // cmbBodyType
            // 
            this.cmbBodyType.FormattingEnabled = true;
            this.cmbBodyType.Location = new System.Drawing.Point(221, 154);
            this.cmbBodyType.Name = "cmbBodyType";
            this.cmbBodyType.Size = new System.Drawing.Size(175, 28);
            this.cmbBodyType.TabIndex = 12;
            // 
            // rbDiesel
            // 
            this.rbDiesel.AutoSize = true;
            this.rbDiesel.Location = new System.Drawing.Point(228, 290);
            this.rbDiesel.Name = "rbDiesel";
            this.rbDiesel.Size = new System.Drawing.Size(78, 24);
            this.rbDiesel.TabIndex = 13;
            this.rbDiesel.TabStop = true;
            this.rbDiesel.Text = "Diesel";
            this.rbDiesel.UseVisualStyleBackColor = true;
            // 
            // rbPetrol
            // 
            this.rbPetrol.AutoSize = true;
            this.rbPetrol.Location = new System.Drawing.Point(312, 290);
            this.rbPetrol.Name = "rbPetrol";
            this.rbPetrol.Size = new System.Drawing.Size(75, 24);
            this.rbPetrol.TabIndex = 14;
            this.rbPetrol.TabStop = true;
            this.rbPetrol.Text = "Petrol";
            this.rbPetrol.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Fuel:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(228, 345);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(155, 33);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // UCAddAdvertisement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rbPetrol);
            this.Controls.Add(this.rbDiesel);
            this.Controls.Add(this.cmbBodyType);
            this.Controls.Add(this.txtMileage);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCAddAdvertisement";
            this.Size = new System.Drawing.Size(639, 406);
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
    }
}
