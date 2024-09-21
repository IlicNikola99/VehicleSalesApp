using Client.UserControls;
using Common.Domain;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Client.GuiController
{
    public class AdvertisementViewGuiController
    {

        private UCAdvertisement viewAdvertisement;
        private string[] imagePaths;
        int selectedImageIndex;
        public Control CreateViewAdvertisement(Advertisement advertisement)
        {
            viewAdvertisement = new UCAdvertisement();
            viewAdvertisement.lblPricePlaceholder.Text = advertisement.Price.ToString() + " €";
            viewAdvertisement.descriptionPlaceholder.Text = advertisement.Description;
            viewAdvertisement.labelMakePlaceholder.Text = advertisement.Vehicle.Make;
            viewAdvertisement.labelModelPlaceholder.Text = advertisement.Vehicle.Model;
            viewAdvertisement.labelBodyPlaceholder.Text = advertisement.Vehicle.BodyType.ToString();
            viewAdvertisement.labelYearPlaceholder.Text = advertisement.Vehicle.Year.ToString();
            viewAdvertisement.labelMileagePlaceholder.Text = advertisement.Vehicle.Mileage.ToString();
            viewAdvertisement.labelFuelPlaceholder.Text = advertisement.Vehicle.FuelType.ToString();
            selectedImageIndex = 0;
            imagePaths = advertisement.Images.Select(x => x.Path).ToArray();
            viewAdvertisement.pictureBox.Image = System.Drawing.Image.FromFile(imagePaths[selectedImageIndex]);
            viewAdvertisement.pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            viewAdvertisement.btnPrevImage.Click += PrevImage;
            viewAdvertisement.btnNextImage.Click += NextImage;

            return viewAdvertisement;
        }

        private void PrevImage(object sender, EventArgs e)
        {
            if (selectedImageIndex == 0)
            {
                selectedImageIndex = imagePaths.Length - 1;
                ShowImage(selectedImageIndex);
            }
            else
            {
                selectedImageIndex = selectedImageIndex - 1;
                ShowImage(selectedImageIndex);
            }
        }

        private void NextImage(object sender, EventArgs e)
        {
            if (selectedImageIndex == imagePaths.Length - 1)
            {
                selectedImageIndex = 0;
                ShowImage(selectedImageIndex);
            }
            else
            {
                selectedImageIndex++;
                ShowImage(selectedImageIndex);
            }
        }

        private void ShowImage(int imageIndex)
        {
            viewAdvertisement.pictureBox.Image = System.Drawing.Image.FromFile(imagePaths[imageIndex]);

        }
    }
}
