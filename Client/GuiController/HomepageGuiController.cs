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
           
            ObservableCollection<CardViewModel> cards = new ObservableCollection<CardViewModel>
            {
                new CardViewModel()
                {
                    MakeModel = "Toyota Corolla",
                    Year = "1999",
                    Price = "2500 $",
                    ImagePath = "C:\\Users\\Nikola\\Downloads\\Slike za app\\Mercedes\\ee8e4ca7125a-800x600-dw.jpg"
                },
                  new CardViewModel()
                {
                    MakeModel = "Mercedes Benz",
                    Year = "2022",
                    Price = "12500 $",
                    ImagePath = "C:\\Users\\Nikola\\Downloads\\Slike za app\\Mercedes\\ee8e4ca7125a-800x600-dw.jpg"
                }
            };
            CardsViewModel VM = new CardsViewModel()
            {
                Cards = cards
            };
            return VM;
        }
    }
}
