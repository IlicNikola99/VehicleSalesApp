using Client.Helpers;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FrmRegister : Form
    {
        public User NewUser { get; private set; }
        List<TextBox> textBoxes = new List<TextBox>();
        public FrmRegister()
        {
            InitializeComponent();
            textBoxes = new List<TextBox>
            {
                txtUsername,
                txtPassword,
                txtRepeatPassword,
                txtFirstName,
                txtLastName,
                txtAddress,
                txtCity,
                txtPhoneNumber
            };
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (!Validator.ValidateForm(textBoxes, lblError)) { return; }
            if (!txtPassword.Text.Equals(txtRepeatPassword.Text))
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            NewUser = new User()
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Address = txtAddress.Text,
                City = txtCity.Text,
                PhoneNumber = txtPhoneNumber.Text
            };

            this.DialogResult = DialogResult.OK;
        }
    }
}
