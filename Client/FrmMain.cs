using Client.GuiController;
using System;
using System.Windows.Forms;

namespace Client
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            itemAddAdvertisement.Click += (s, a) => MainCoordinator.Instance.ShowAddAdvertisementPanel();
            itemHome.Click += (s, a) => MainCoordinator.Instance.ShowHomePanel();
            this.WindowState = FormWindowState.Maximized;
        }

        public void ChangePanel(Control control)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(control);
            control.Dock = DockStyle.Fill;
            pnlMain.AutoSize = true;
            pnlMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            MainCoordinator.Instance.ShowHomePanel();
        }
    }
}
