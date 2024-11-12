using Client.Helpers;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Client.GuiController
{
    public class LoginGuiController
    {

        private static LoginGuiController instance;
        public User LoggedInUser { get; set; }
        public static LoginGuiController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoginGuiController();
                }
                return instance;
            }
        }
        private LoginGuiController()
        {
        }

        private FrmLogin frmLogin;

        internal void ShowFrmLogin()
        {
            Communication.Instance.Connect();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin = new FrmLogin
            {
                AutoSize = true
            };
            Application.Run(frmLogin);
        }

        public void Login(object sender, EventArgs e)
        {
            if (!Validator.ValidateForm(new List<System.Windows.Forms.TextBox>() { frmLogin.TxtUsername,
                frmLogin.TxtPassword }, frmLogin.lblError))
            {
                return;
            }

            User user = new User
            {
                Username = frmLogin.TxtUsername.Text,
                Password = frmLogin.TxtPassword.Text,
            };
            Response response = Communication.Instance.Login(user);
            if (response.Exception == null)
            {
                LoggedInUser = (User)response.Result;
                frmLogin.Visible = false;
                MainCoordinator.Instance.ShowFrmMain();
            }
            else
            {
                MessageBox.Show(response.Exception.Message);
            }
        }

        public void RegisterUser(object sender, EventArgs e)
        {
            User newUser;
            using (var frmRegister = new FrmRegister())
            {
                var result = frmRegister.ShowDialog();
                if (result == DialogResult.OK)
                {
                    newUser = frmRegister.NewUser;
                }
                else
                {
                    return;
                }
            }

            Response response = Communication.Instance.Register(newUser);
            if (response.Exception == null)
            {
                MessageBox.Show("Registration successfull, you can login now!");

            }
            else
            {
                MessageBox.Show(">>>" + response.Exception.ToString());
            }
        }

        internal void FormClosed(object sender, FormClosedEventArgs e)
        {
            Communication.Instance.Disconnect();
        }
    }
}