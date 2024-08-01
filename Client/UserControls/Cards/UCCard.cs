using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UserControls.Cards
{
    public partial class UCCard : UserControl
    {
        public CardViewModel ViewModel { get; set; }

        public UCCard()
        {
            InitializeComponent();
        }
        public UCCard(CardViewModel viewModel)
        {
            ViewModel = viewModel;
            InitializeComponent();
        }

        public void DataBind()
        {
            SuspendLayout();

            lblMakeModel.Text = ViewModel.MakeModel;
            lblPrice.Text = ViewModel.Price;
            lblYear.Text = ViewModel.Year;
            pictureBox.Image = Image.FromFile(ViewModel.ImagePath);
            ResumeLayout();
        }
    }

    public class CardsViewModel
    {
        public ObservableCollection<CardViewModel> Cards { get; set; }
    }

    public class CardViewModel
    {
        public string ImagePath { get; set; }
        public string MakeModel { get; set; }
        public string Price { get; set; }
        public string Year { get; set; }
    }
}
