﻿namespace Client.UserControls
{
    partial class UCSearch
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
            this.txtMileageTo = new System.Windows.Forms.TextBox();
            this.txtYearTo = new System.Windows.Forms.TextBox();
            this.txtMaxPrice = new System.Windows.Forms.TextBox();
            this.txtMinPrice = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbMake = new System.Windows.Forms.ComboBox();
            this.cmbBodyType = new System.Windows.Forms.ComboBox();
            this.cmbFuelType = new System.Windows.Forms.ComboBox();
            this.btnResetSelection = new System.Windows.Forms.Button();
            this.txtYearFrom = new System.Windows.Forms.TextBox();
            this.txtMileageFrom = new System.Windows.Forms.TextBox();
            this.cmbPageSize = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtMileageTo
            // 
            this.txtMileageTo.Location = new System.Drawing.Point(322, 96);
            this.txtMileageTo.Name = "txtMileageTo";
            this.txtMileageTo.Size = new System.Drawing.Size(122, 20);
            this.txtMileageTo.TabIndex = 17;
            this.txtMileageTo.Text = "Mileage to";
            this.txtMileageTo.Enter += new System.EventHandler(this.EraseText);
            this.txtMileageTo.Leave += new System.EventHandler(this.ReEnterText);
            // 
            // txtYearTo
            // 
            this.txtYearTo.Location = new System.Drawing.Point(166, 60);
            this.txtYearTo.Name = "txtYearTo";
            this.txtYearTo.Size = new System.Drawing.Size(122, 20);
            this.txtYearTo.TabIndex = 16;
            this.txtYearTo.Text = "Year to";
            this.txtYearTo.Enter += new System.EventHandler(this.EraseText);
            this.txtYearTo.Leave += new System.EventHandler(this.ReEnterText);
            // 
            // txtMaxPrice
            // 
            this.txtMaxPrice.Location = new System.Drawing.Point(481, 22);
            this.txtMaxPrice.Name = "txtMaxPrice";
            this.txtMaxPrice.Size = new System.Drawing.Size(122, 20);
            this.txtMaxPrice.TabIndex = 15;
            this.txtMaxPrice.Text = "Price To";
            this.txtMaxPrice.Enter += new System.EventHandler(this.EraseText);
            this.txtMaxPrice.Leave += new System.EventHandler(this.ReEnterText);
            // 
            // txtMinPrice
            // 
            this.txtMinPrice.Location = new System.Drawing.Point(322, 22);
            this.txtMinPrice.Name = "txtMinPrice";
            this.txtMinPrice.Size = new System.Drawing.Size(122, 20);
            this.txtMinPrice.TabIndex = 14;
            this.txtMinPrice.Text = "Price From";
            this.txtMinPrice.Enter += new System.EventHandler(this.EraseText);
            this.txtMinPrice.Leave += new System.EventHandler(this.ReEnterText);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(166, 22);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(122, 20);
            this.txtModel.TabIndex = 13;
            this.txtModel.Text = "Model";
            this.txtModel.Enter += new System.EventHandler(this.EraseText);
            this.txtModel.Leave += new System.EventHandler(this.ReEnterText);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(257, 162);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // cmbMake
            // 
            this.cmbMake.FormattingEnabled = true;
            this.cmbMake.Location = new System.Drawing.Point(22, 21);
            this.cmbMake.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMake.Name = "cmbMake";
            this.cmbMake.Size = new System.Drawing.Size(122, 21);
            this.cmbMake.TabIndex = 20;
            this.cmbMake.Text = "Make";
            // 
            // cmbBodyType
            // 
            this.cmbBodyType.FormattingEnabled = true;
            this.cmbBodyType.Location = new System.Drawing.Point(322, 60);
            this.cmbBodyType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBodyType.Name = "cmbBodyType";
            this.cmbBodyType.Size = new System.Drawing.Size(122, 21);
            this.cmbBodyType.TabIndex = 21;
            this.cmbBodyType.Text = "Body Type";
            // 
            // cmbFuelType
            // 
            this.cmbFuelType.FormattingEnabled = true;
            this.cmbFuelType.Location = new System.Drawing.Point(481, 60);
            this.cmbFuelType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFuelType.Name = "cmbFuelType";
            this.cmbFuelType.Size = new System.Drawing.Size(122, 21);
            this.cmbFuelType.TabIndex = 22;
            this.cmbFuelType.Text = "Fuel Type";
            // 
            // btnResetSelection
            // 
            this.btnResetSelection.ForeColor = System.Drawing.Color.Crimson;
            this.btnResetSelection.Location = new System.Drawing.Point(492, 94);
            this.btnResetSelection.Name = "btnResetSelection";
            this.btnResetSelection.Size = new System.Drawing.Size(89, 23);
            this.btnResetSelection.TabIndex = 23;
            this.btnResetSelection.Text = "Reset Selection";
            this.btnResetSelection.UseVisualStyleBackColor = true;
            // 
            // txtYearFrom
            // 
            this.txtYearFrom.Location = new System.Drawing.Point(22, 61);
            this.txtYearFrom.Name = "txtYearFrom";
            this.txtYearFrom.Size = new System.Drawing.Size(122, 20);
            this.txtYearFrom.TabIndex = 24;
            this.txtYearFrom.Text = "Year from";
            this.txtYearFrom.Enter += new System.EventHandler(this.EraseText);
            this.txtYearFrom.Leave += new System.EventHandler(this.ReEnterText);
            // 
            // txtMileageFrom
            // 
            this.txtMileageFrom.Location = new System.Drawing.Point(166, 96);
            this.txtMileageFrom.Name = "txtMileageFrom";
            this.txtMileageFrom.Size = new System.Drawing.Size(122, 20);
            this.txtMileageFrom.TabIndex = 25;
            this.txtMileageFrom.Text = "Mileage From";
            this.txtMileageFrom.Enter += new System.EventHandler(this.EraseText);
            this.txtMileageFrom.Leave += new System.EventHandler(this.ReEnterText);
            // 
            // cmbPageSize
            // 
            this.cmbPageSize.FormattingEnabled = true;
            this.cmbPageSize.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6"});
            this.cmbPageSize.Location = new System.Drawing.Point(22, 96);
            this.cmbPageSize.Name = "cmbPageSize";
            this.cmbPageSize.Size = new System.Drawing.Size(122, 21);
            this.cmbPageSize.TabIndex = 26;
            this.cmbPageSize.Text = "Page Size";
            // 
            // UCSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.cmbPageSize);
            this.Controls.Add(this.txtMileageFrom);
            this.Controls.Add(this.txtYearFrom);
            this.Controls.Add(this.btnResetSelection);
            this.Controls.Add(this.cmbFuelType);
            this.Controls.Add(this.cmbBodyType);
            this.Controls.Add(this.cmbMake);
            this.Controls.Add(this.txtMileageTo);
            this.Controls.Add(this.txtYearTo);
            this.Controls.Add(this.txtMaxPrice);
            this.Controls.Add(this.txtMinPrice);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.btnSearch);
            this.Name = "UCSearch";
            this.Size = new System.Drawing.Size(606, 188);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox cmbMake;
        public System.Windows.Forms.ComboBox cmbBodyType;
        public System.Windows.Forms.ComboBox cmbFuelType;
        public System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.TextBox txtMileageTo;
        public System.Windows.Forms.TextBox txtYearTo;
        public System.Windows.Forms.TextBox txtMaxPrice;
        public System.Windows.Forms.TextBox txtMinPrice;
        public System.Windows.Forms.TextBox txtModel;
        public System.Windows.Forms.Button btnResetSelection;
        public System.Windows.Forms.TextBox txtYearFrom;
        public System.Windows.Forms.TextBox txtMileageFrom;
        public System.Windows.Forms.ComboBox cmbPageSize;
    }
}
