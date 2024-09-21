using Client.UserControls;
using Client.UserControls.Cards;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Client.GuiController
{
    public class HomepageGuiController
    {
        private const string NO_MAKE_SELECTED = "No Make Selected";
        private const string BODY_TYPE = "Body Type";
        private const string FUEL_TYPE = "Fuel Type";
        private UCHomepage homepage;
        private List<Advertisement> allAdvertisements;
        UCSearch ucSearch;
        ObservableCollection<CardViewModel> cards;
        CardsViewModel VM;

        internal Control CreateHomepage()
        {
            homepage = new UCHomepage();
            homepage.Load += new EventHandler(UCHomepage_Load);
            ucSearch = new UCSearch();

            return homepage;
        }
        public void UCHomepage_Load(object sender, EventArgs e)
        {
            GetAllAdvertisements();
            homepage.cardsPanel.ViewModel = LoadData();
            homepage.cardsPanel.DataBind();
            homepage.searchPanel.Controls.Clear();
            List<string> makeNames = allAdvertisements.Select(add => add.Vehicle.Make).Distinct().ToList();
            makeNames.Insert(0, NO_MAKE_SELECTED);
            ucSearch.cmbMake.DataSource = makeNames;

            var bodyTypes = Enum.GetValues(typeof(BodyType))
                     .Cast<BodyType>()
                     .Select(bt => bt.ToString())
                     .ToList();
            bodyTypes.Insert(0, BODY_TYPE);
            ucSearch.cmbBodyType.DataSource = bodyTypes;


            var fuelTypes = Enum.GetValues(typeof(FuelType))
                    .Cast<FuelType>()
                    .Select(ft => ft.ToString())
                    .ToList();
            fuelTypes.Insert(0, FUEL_TYPE);
            ucSearch.cmbFuelType.DataSource = fuelTypes;
            
            ucSearch.btnSearch.Click += BtnSearch_Click;
            ucSearch.btnResetSelection.Click += BtnResetSelection_Click;
            homepage.searchPanel.Controls.Add(ucSearch);

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            GetAllAdvertisements();
            string make = ucSearch.cmbMake.SelectedItem.ToString();
            string model = ucSearch.txtModel.Text;
            string bodyType = ucSearch.cmbBodyType.Text;
            string fuelType = ucSearch.cmbFuelType.Text;

            if (decimal.TryParse(ucSearch.txtMinPrice.Text, out decimal minPrice) && minPrice >= 0)
            {
                allAdvertisements = allAdvertisements.Where(add => add.Price >= minPrice).ToList();
            }

            if (decimal.TryParse(ucSearch.txtMaxPrice.Text, out decimal maxPrice))
            {
                allAdvertisements = allAdvertisements.Where(add => add.Price <= maxPrice).ToList();
            }

            if (int.TryParse(ucSearch.txtMileageFrom.Text, out int mileageFrom))
            {
                allAdvertisements = allAdvertisements.Where(add => add.Vehicle.Mileage >= mileageFrom).ToList();
            }

            if (int.TryParse(ucSearch.txtMileageTo.Text, out int mileageTo))
            {
                allAdvertisements = allAdvertisements.Where(add => add.Vehicle.Mileage <= mileageTo).ToList();
            }
            if (int.TryParse(ucSearch.txtYearFrom.Text, out int yearFrom))
            {
                allAdvertisements = allAdvertisements.Where(add => add.Vehicle.Year >= yearFrom).ToList();
            }

            if (int.TryParse(ucSearch.txtYearTo.Text, out int yearTo))
            {
                allAdvertisements = allAdvertisements.Where(add => add.Vehicle.Year <= yearTo).ToList();
            }

            if (!string.IsNullOrEmpty(model) && !model.Equals("Model"))
            {
                allAdvertisements = allAdvertisements.Where(add => add.Vehicle.Model.Equals(model)).ToList();

            }
            if (!string.IsNullOrEmpty(make) && !make.Equals(NO_MAKE_SELECTED))
            {
                allAdvertisements = allAdvertisements.Where(add => add.Vehicle.Make.Equals(make)).ToList();
            }

            if (!string.IsNullOrEmpty(bodyType) &&  !bodyType.Equals(BODY_TYPE))
            {
                allAdvertisements = allAdvertisements.Where(add => add.Vehicle.BodyType.ToString().Equals(bodyType)).ToList();
            }

            if (!string.IsNullOrEmpty(fuelType) && !fuelType.Equals(FUEL_TYPE))
            {
                allAdvertisements = allAdvertisements.Where(add => add.Vehicle.FuelType.ToString().Equals(fuelType)).ToList();
            }
            homepage.cardsPanel.ViewModel = LoadData();
            ReloadCards();

        }

        private void BtnResetSelection_Click(object sender, EventArgs e)
        {
            GetAllAdvertisements();
            homepage.cardsPanel.ViewModel = LoadData();
            homepage.cardsPanel.DataBind();

        }

        private void ReloadCards()
        {
            homepage.cardsPanel.DataBind();
        }

        private CardsViewModel LoadData()
        {
            List<CardViewModel> cardViews = allAdvertisements.Select(advertisement =>
            {
                CardViewModel cardViewModel = new CardViewModel()
                {
                    ImagePath = advertisement.Images[0].Path,
                    MakeModel = advertisement.Vehicle.Make + " " + advertisement.Vehicle.Model,
                    Year = advertisement.Vehicle.Year.ToString(),
                    Price = advertisement.Price.ToString() + " €",
                    Advertisement = advertisement
                };
                return cardViewModel;
            }).ToList();

            cards = new ObservableCollection<CardViewModel>(cardViews);
            VM = new CardsViewModel()
            {
                Cards = cards
            };
            return VM;
        }

        private void GetAllAdvertisements()
        {
            Response response = Communication.Instance.GetAllAdvertisements();
            if (response.Exception != null)
            {
                Debug.WriteLine(">>>>> Error when fetching advertisements!");
                throw response.Exception;
            }
            allAdvertisements = (List<Advertisement>)response.Result;
        }
    }
}
