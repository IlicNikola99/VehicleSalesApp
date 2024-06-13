using Client.Helpers;
using Client.UserControls;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using TextBox = System.Windows.Forms.TextBox;

namespace Client.GuiController
{
    public class AdvertisementGuiController
    {

        private UCAddAdvertisement addAdvertisement;
        private List<TextBox> textBoxes;
        internal Control CreateAddAdvertisement()
        {
            addAdvertisement = new UCAddAdvertisement();
            addAdvertisement.btnSubmit.Click += AddAdvertisement;
            addAdvertisement.rbDiesel.Checked = true;
            addAdvertisement.cmbBodyType.DataSource= Enum.GetValues(typeof(BodyType));

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

        private void AddAdvertisement(object sender, EventArgs e)
        {
            if (!Validator.ValidateForm(textBoxes, addAdvertisement.lblError)) { return; }
            Vehicle addedVehicle = AddVehicle();
            if (addedVehicle != null)
            {
                //dodaj oglas
            }
        }
        private Vehicle AddVehicle()
        {
            Vehicle vehicle = new Vehicle
            {
                Make = addAdvertisement.txtMake.Text,
                Model = addAdvertisement.txtModel.Text,
                BodyType = (BodyType) addAdvertisement.cmbBodyType.SelectedItem,
                Year = int.Parse(addAdvertisement.txtYear.Text),
                Mileage = int.Parse(addAdvertisement.txtMileage.Text),
                FuelType = addAdvertisement.rbDiesel.Checked? FuelType.Diesel: FuelType.Petrol
            };
            Response response = Communication.Instance.CreateVehicle(vehicle);
            if (response.Exception == null)
            {
                Debug.WriteLine("Vehicle succesfully added!");
                return vehicle;
            }
            else
            {
                Debug.WriteLine(">>>>> Error when adding new vehicle!");
                throw response.Exception;
            }
        }

    }
}
