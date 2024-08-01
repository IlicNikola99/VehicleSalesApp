using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UserControls.Cards
{
    public class CardsPanel : Panel
    {
        const int CardWidth = 200;
        const int CardHeight = 150;

        public CardsViewModel ViewModel { get; set; }

        public CardsPanel()
        {
        }
        public CardsPanel(CardsViewModel viewModel)
        {
            ViewModel = viewModel;
            ViewModel.Cards.CollectionChanged += Cards_CollectionChanged;
        }

        private void Cards_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            DataBind();
        }

        public void DataBind()
        {
            SuspendLayout();
            Controls.Clear();

            for (int i = 0; i < ViewModel.Cards.Count; i++)
            {
                var newCardControl = new UCCard(ViewModel.Cards[i]);
                newCardControl.DataBind();
                SetCardControlLayout(newCardControl, i);
                Controls.Add(newCardControl);
            }
            ResumeLayout();
        }

        void SetCardControlLayout(UCCard ctl, int atIndex)
        {
            ctl.Width = CardWidth;
            ctl.Height = CardHeight;

            //calc visible column count
            int columnCount = Width / CardWidth;

            //calc the x index and y index.
            int xPos = (atIndex % columnCount) * CardWidth;
            int yPos = (atIndex / columnCount) * CardHeight;

            ctl.Location = new Point(xPos, yPos);
        }
    }
}
