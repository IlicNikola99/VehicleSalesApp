using System;
using System.Windows.Forms;

namespace Client.UserControls
{
    public partial class UCSearch : UserControl
    {
        public UCSearch()
        {
            InitializeComponent();
        }

        private void EraseText(object sender, EventArgs e)
        {
            TextBox thisTextBox = sender as TextBox;
            thisTextBox.Text = string.Empty;
        }

        private void ReEnterText(object sender, EventArgs e)
        {
            TextBox thisTextBox = sender as TextBox;

            if (thisTextBox.Text == string.Empty)
            {
                switch (thisTextBox.Name)
                {
                    case "txtModel":
                        thisTextBox.Text = "Model";
                        break;
                    case "txtMinPrice":
                        thisTextBox.Text = "Price From";
                        break;
                    case "txtMaxPrice":
                        thisTextBox.Text = "Price To";
                        break;
                    case "txtYearFrom":
                        thisTextBox.Text = "Year From";
                        break;
                    case "txtYearTo":
                        thisTextBox.Text = "Year To";
                        break;
                    case "txtMileageFrom":
                        thisTextBox.Text = "Mileage From";
                        break;
                    case "txtMileageTo":
                        thisTextBox.Text = "Mileage To";
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
