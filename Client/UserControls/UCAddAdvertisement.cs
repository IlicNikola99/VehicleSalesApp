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
    }
}
