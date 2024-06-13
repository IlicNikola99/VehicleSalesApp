using System.Linq;
using System.Windows.Forms;

namespace Client.UserControls
{
    public partial class UCAddAdvertisement : UserControl
    {
        public UCAddAdvertisement()
        {
            InitializeComponent();
        }

        private void TxtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void TxtMileage_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void TxtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Check if the pressed key is not a digit, control character, or dot
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Disallow the key press
            }
            // Check if the pressed key is a dot and if the textbox already contains a dot
            else if (e.KeyChar == '.' && textBox.Text.Contains('.'))
            {
                e.Handled = true; // Disallow the key press if a dot already exists
            }

        }
    }
}
