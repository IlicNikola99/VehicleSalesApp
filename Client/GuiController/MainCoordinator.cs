using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GuiController
{
    internal class MainCoordinator
    {
        private static MainCoordinator instance;
        public static MainCoordinator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainCoordinator();
                }
                return instance;
            }
        }

        private MainCoordinator()
        {
            advertisementGuiController = new AdvertisementGuiController();
            homepageGuiController = new HomepageGuiController();
        }

        private FrmMain frmMain;
        private AdvertisementGuiController advertisementGuiController;
        private HomepageGuiController homepageGuiController;

        internal void ShowFrmMain()
        {
            frmMain = new FrmMain();
            frmMain.AutoSize = true;
            frmMain.ShowDialog();
        }

        internal void ShowAddAdvertisementPanel()
        {
            frmMain.ChangePanel(advertisementGuiController.CreateAddAdvertisement());
        }
        internal void ShowHomePanel()
        {
            frmMain.ChangePanel(homepageGuiController.CreateHomepage());
        }

    }
}
