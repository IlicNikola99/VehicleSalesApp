using Client.UserControls;
using Client.UserControls.Cards;
using Common.Communication;
using Common.Domain;
using Server.SystemOperation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GuiController
{
    public class HomepageGuiController
    {
        private UCHomepage homepage;
        internal Control CreateHomepage()
        {
            homepage = new UCHomepage();
            homepage.Load += new EventHandler(UCHomepage_Load);

            //addAdvertisement.btnSubmit.Click += AddAdvertisement;
            //addAdvertisement.btnUploadImages.Click += UploadImages;
            //addAdvertisement.btnResetSelection.Click += ResetSelection;
            //addAdvertisement.rbDiesel.Checked = true;
            //addAdvertisement.cmbBodyType.DataSource = Enum.GetValues(typeof(BodyType));



            return homepage;
        }
        public void UCHomepage_Load(object sender, EventArgs e)
        {
            homepage.cardsPanel.ViewModel = LoadData();
            homepage.cardsPanel.DataBind();

        }

        private CardsViewModel LoadData()
        {
            Response response = Communication.Instance.GetAllAdvertisements();
            if (response.Exception != null)
            {
                Debug.WriteLine(">>>>> Error when fetching advertisements!");
                throw response.Exception;
            }
            List<Advertisement> allAdvertisements = (List<Advertisement>) response.Result;
            List<CardViewModel> cardViews = allAdvertisements.Select( advertisement => {
                CardViewModel cardViewModel = new CardViewModel()
                {
                    ImagePath = advertisement.Images[0].Path,
                    MakeModel = advertisement.Vehicle.Make + " " + advertisement.Vehicle.Model,
                    Year = advertisement.Vehicle.Year.ToString(),
                    Price = advertisement.Price.ToString() + " €"
                };
                return cardViewModel;
            }).ToList();

            ObservableCollection<CardViewModel> cards = new ObservableCollection<CardViewModel>(cardViews);
            CardsViewModel VM = new CardsViewModel()
            {
                Cards = cards
            };
            return VM;
        }
    }
}
