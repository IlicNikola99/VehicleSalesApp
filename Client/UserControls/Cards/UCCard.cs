using Common.Domain;
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
using Image = System.Drawing.Image;

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

        private void UCCard_Click(object sender, EventArgs e)
        {
            if(this.ViewModel!= null)
            {
                MessageBox.Show(ViewModel.Advertisement.Id.ToString());
            }
        }

        private void UCCard_MouseHover(object sender, EventArgs e)
        {
            this.lblMakeModel.ForeColor = Color.SteelBlue;
            this.lblPrice.ForeColor = Color.SteelBlue;
            this.lblYear.ForeColor = Color.SteelBlue;

        }

        private void UCCard_MouseLeave(object sender, EventArgs e)
        {
            this.lblMakeModel.ForeColor = Color.Black;
            this.lblPrice.ForeColor = Color.Black;
            this.lblYear.ForeColor = Color.Black;
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
        public Advertisement Advertisement { get; set; } //only used for data transfer
    }
}
