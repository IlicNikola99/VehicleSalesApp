using Client.GuiController;
using Common.Communication;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            txtUsername.Text = "testUsername";
            txtPassword.Text = "testPassword";
            btnLogin.Click += LoginGuiController.Instance.Login;
            button1.Click += LoginGuiController.Instance.AddUserTest;
            FormClosed += LoginGuiController.Instance.FormClosed;
        }
    }
}
