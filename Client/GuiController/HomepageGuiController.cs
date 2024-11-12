using Client.Helpers;
using Client.UserControls;
using Client.UserControls.Cards;
using Common.Communication;
using Common.Domain;
using Common.Helpers;
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
        int page = 0;
        const int PAGE_SIZE = 5;

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
            homepage.cardsPanel.ViewModel = LoadPagedData();
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
            homepage.btnNextPage.Click += NextPage;
            homepage.btnPreviousPage.Click += PreviousPage;

        }

        private void NextPage(object sender, EventArgs e)
        {
            if ((page + 1) * PAGE_SIZE < allAdvertisements.Count)
            {
                page++;
                homepage.cardsPanel.ViewModel = LoadPagedData();
                ReloadCards();
            }
        }

        private void PreviousPage(object sender, EventArgs e)
        {
            if (page > 0)
            {
                page--;
                homepage.cardsPanel.ViewModel = LoadPagedData();
                ReloadCards();
            }
        }

        private CardsViewModel LoadPagedData()
        {
            var pagedAdvertisements = allAdvertisements
                .Skip(page * PAGE_SIZE)
                .Take(PAGE_SIZE)
                .Select(advertisement => new CardViewModel()
                {
                    MakeModel = advertisement.Vehicle.Make + " " + advertisement.Vehicle.Model,
                    Year = advertisement.Year.ToString(),
                    Price = advertisement.Price.ToString() + " €",
                    Advertisement = advertisement,
                    ImagePath = advertisement.Images.FirstOrDefault(img => img.Thumbnail)?.Path
                                ?? advertisement.Images.FirstOrDefault()?.Path
                                ?? PlaceHolderImage.GetPlaceHolderImage().Path
                })
                .ToList();

            cards = new ObservableCollection<CardViewModel>(pagedAdvertisements);
            VM = new CardsViewModel()
            {
                Cards = cards
            };
            return VM;
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
                allAdvertisements = allAdvertisements.Where(add => add.Mileage >= mileageFrom).ToList();
            }

            if (int.TryParse(ucSearch.txtMileageTo.Text, out int mileageTo))
            {
                allAdvertisements = allAdvertisements.Where(add => add.Mileage <= mileageTo).ToList();
            }
            if (int.TryParse(ucSearch.txtYearFrom.Text, out int yearFrom))
            {
                allAdvertisements = allAdvertisements.Where(add => add.Year >= yearFrom).ToList();
            }

            if (int.TryParse(ucSearch.txtYearTo.Text, out int yearTo))
            {
                allAdvertisements = allAdvertisements.Where(add => add.Year <= yearTo).ToList();
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
                allAdvertisements = allAdvertisements.Where(add => add.FuelType.ToString().Equals(fuelType)).ToList();
            }
            homepage.cardsPanel.ViewModel = LoadPagedData();
            ReloadCards();

        }

        private void BtnResetSelection_Click(object sender, EventArgs e)
        {
            GetAllAdvertisements();
            homepage.cardsPanel.ViewModel = LoadPagedData();
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
                    MakeModel = advertisement.Vehicle.Make + " " + advertisement.Vehicle.Model,
                    Year = advertisement.Year.ToString(),
                    Price = advertisement.Price.ToString() + " €",
                    Advertisement = advertisement
                };

                if(advertisement.Images.Count > 0 )
                {
                    var thumbnailImage = advertisement.Images.FirstOrDefault(img => img.Thumbnail);
                    if (thumbnailImage == null)
                        thumbnailImage = advertisement.Images.First();
                    cardViewModel.ImagePath = thumbnailImage?.Path;
                }
                else
                {
                    cardViewModel.ImagePath = PlaceHolderImage.GetPlaceHolderImage().Path;
                }

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
