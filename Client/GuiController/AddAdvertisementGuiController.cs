using Client.Helpers;
using Client.UserControls;
using Common.Communication;
using Common.Domain;
using Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TextBox = System.Windows.Forms.TextBox;

namespace Client.GuiController
{
    public class AddAdvertisementGuiController
    {

        private UCAddAdvertisement addAdvertisement;
        private List<TextBox> textBoxes;
        private string[] uploadedImagePaths;
        private Advertisement currentAdvertisement;
        internal Control CreateAddAdvertisement()
        {
            addAdvertisement = new UCAddAdvertisement();
            addAdvertisement.btnSubmit.Click += AddAdvertisement;
            addAdvertisement.btnUploadImages.Click += UploadImages;
            addAdvertisement.btnResetSelection.Text = "Reset Selection";
            addAdvertisement.btnResetSelection.Click += ResetSelection;
            addAdvertisement.rbDiesel.Checked = true;
            addAdvertisement.cmbBodyType.DataSource = Enum.GetValues(typeof(BodyType));

            textBoxes = new List<TextBox>
            {
                addAdvertisement.txtMake,
                addAdvertisement.txtModel,
                addAdvertisement.txtPrice,
                addAdvertisement.txtYear,
                addAdvertisement.txtMileage

            };

            return addAdvertisement;
        }

        internal Control CreateUpdateAdvertisement(Advertisement advertisement)
        {
            addAdvertisement = new UCAddAdvertisement();
            currentAdvertisement = advertisement;
            addAdvertisement.btnSubmit.Click += UpdateAdvertisement;
            addAdvertisement.btnUploadImages.Click += UploadImages;
            addAdvertisement.btnResetSelection.Text = "Remove Images";
            addAdvertisement.btnResetSelection.Click += RemoveImages;

            addAdvertisement.txtMake.Text = advertisement.Vehicle.Make;
            addAdvertisement.txtModel.Text = advertisement.Vehicle.Model;
            addAdvertisement.txtPrice.Text = advertisement.Price.ToString();
            addAdvertisement.txtYear.Text = advertisement.Vehicle.Year.ToString();
            addAdvertisement.txtMileage.Text = advertisement.Vehicle.Mileage.ToString();
            addAdvertisement.txtDescription.Text = advertisement.Description;
            addAdvertisement.cmbBodyType.DataSource = Enum.GetValues(typeof(BodyType));
            addAdvertisement.cmbBodyType.SelectedItem = advertisement.Vehicle.BodyType;
            if (advertisement.Vehicle.FuelType.Equals(FuelType.Petrol))
            {
                addAdvertisement.rbPetrol.Checked = true;
            }
            else
            {
                addAdvertisement.rbDiesel.Checked = true;
            }

            List<string> filePaths = new List<string>(); 
            foreach (var img in advertisement.Images)
            {
                filePaths.Add(img.Path);
            }
            PopulateImagePanel(filePaths.ToArray());

            textBoxes = new List<TextBox>
            {
                addAdvertisement.txtMake,
                addAdvertisement.txtModel,
                addAdvertisement.txtPrice,
                addAdvertisement.txtYear,
                addAdvertisement.txtMileage

            };

            return addAdvertisement;
        }

        private void UploadImages(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Please select multiple images";
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            openFileDialog.CheckFileExists = true;

            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                string[] filePaths = openFileDialog.FileNames;
                PopulateImagePanel(filePaths);
            }
        }

        private void PopulateImagePanel(string[] filePaths)
        {
            int x = 20; int y = 20;
            int maxHeight = -1;
            foreach (var img in filePaths)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = System.Drawing.Image.FromFile(img);
                pictureBox.Location = new Point(x, y);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                x += pictureBox.Width + 10;
                maxHeight = Math.Max(pictureBox.Height, maxHeight);
                if (x > addAdvertisement.pnlImages.ClientSize.Width - 100)
                {
                    x = 20;
                    y += maxHeight + 10;

                }
                addAdvertisement.pnlImages.Controls.Add(pictureBox);
                this.uploadedImagePaths = filePaths;
            }
        }

        private void ResetSelection(object sender, EventArgs e)
        {
            addAdvertisement.pnlImages.Controls.Clear();
            this.uploadedImagePaths = null;
        }

        private void AddAdvertisement(object sender, EventArgs e)
        {
            if (!Validator.ValidateForm(textBoxes, addAdvertisement.lblError)) { return; }
            Vehicle addedVehicle = AddVehicle();
            if (addedVehicle != null && addedVehicle.Id != null)
            {
                Advertisement advertisement = new Advertisement
                {
                    User = LoginGuiController.Instance.LoggedInUser,
                    Vehicle = addedVehicle,
                    Price = decimal.Parse(addAdvertisement.txtPrice.Text),
                    Description = addAdvertisement.txtDescription.Text,
                    AcceptsExchange = addAdvertisement.checkBoxExchange.Checked
                };
                Response response = Communication.Instance.CreateAdvertisement(advertisement);
                if (response.Exception == null)
                {
                    UploadImages((Advertisement)response.Result);
                    Debug.WriteLine("Advertisement succesfully added!");
                    MessageBox.Show("Advertisement succesfully added!");
                }
                else
                {
                    Debug.WriteLine(">>>>> Error when adding new advertisement!");
                    throw response.Exception;
                }
            }
        }

        private void UploadImages(Advertisement advertisement)
        {
            if (uploadedImagePaths == null || uploadedImagePaths.Length == 0)
            {
                throw new Exception("No images are uploaded!");
            }
            List<Common.Domain.Image> images = uploadedImagePaths.Select(path => new Common.Domain.Image(advertisement.Id, path)).ToList();

            Response response = Communication.Instance.UploadImages(images);
            if (response.Exception == null)
            {
                Debug.WriteLine("Images succesfully uploaded!");
            }
            else
            {
                Debug.WriteLine(">>>>> Error when uploading images!");
                throw response.Exception;
            }
        }

        private Vehicle AddVehicle()
        {
            Vehicle vehicle = new Vehicle
            {
                Make = addAdvertisement.txtMake.Text,
                Model = addAdvertisement.txtModel.Text,
                BodyType = (BodyType)addAdvertisement.cmbBodyType.SelectedItem,
                Year = int.Parse(addAdvertisement.txtYear.Text),
                Mileage = int.Parse(addAdvertisement.txtMileage.Text),
                FuelType = addAdvertisement.rbDiesel.Checked ? FuelType.Diesel : FuelType.Petrol
            };
            Response response = Communication.Instance.CreateVehicle(vehicle);
            if (response.Exception == null)
            {
                Debug.WriteLine("Vehicle succesfully added!");
                return (Vehicle)response.Result;
            }
            else
            {
                Debug.WriteLine(">>>>> Error when adding new vehicle!");
                throw response.Exception;
            }
        }

        private void UpdateAdvertisement(object sender, EventArgs e)
        {
            UploadImages(currentAdvertisement);
        }

        private void RemoveImages(object sender, EventArgs e)
        {
            addAdvertisement.pnlImages.Controls.Clear();
            this.uploadedImagePaths = null;
            Response response = Communication.Instance.RemoveAllImagesForAdvertisement(currentAdvertisement.Id);

        }

    }
}
