using Common.Domain;
using Server;
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
            advertisementGuiController = new AddAdvertisementGuiController();
            homepageGuiController = new HomepageGuiController();
            advertisementViewGuiController = new AdvertisementViewGuiController();
        }

        private FrmMain frmMain;
        private AddAdvertisementGuiController advertisementGuiController;
        private HomepageGuiController homepageGuiController;
        private AdvertisementViewGuiController advertisementViewGuiController;

        internal void ShowFrmMain()
        {
            frmMain = new FrmMain();
            frmMain.AutoSize = true;
            frmMain.ShowDialog();
            ShowHomePanel();
        }

        internal void ShowAddAdvertisementPanel()
        {
            frmMain.ChangePanel(advertisementGuiController.CreateAddAdvertisement());
        }
        internal void ShowHomePanel()
        {
            frmMain.ChangePanel(homepageGuiController.CreateHomepage());
        }

        internal void ShowAdvertisementPanel(Advertisement advertisement)
        {
            frmMain.ChangePanel(advertisementViewGuiController.CreateViewAdvertisement(advertisement));
        }

    }
}
