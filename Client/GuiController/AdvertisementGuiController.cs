using Client.UserControls;
using Common.Communication;
using Common.Domain;
using Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GuiController
{
    public class AdvertisementGuiController
    {

        private UCAddAdvertisement addAdvertisement;

        internal Control CreateAddAdvertisement()
        {
            addAdvertisement = new UCAddAdvertisement();
            addAdvertisement.btnSubmit.Click += AddAdvertisement;
            addAdvertisement.rbDiesel.Checked = true;
            addAdvertisement.cmbBodyType.DataSource= Enum.GetValues(typeof(BodyType));
            return addAdvertisement;
        }

        private void AddAdvertisement(object sender, EventArgs e)
        {
            AddVehicle();
        }
        private void AddVehicle()
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
            }
            else
            {
                throw response.Exception;
            }
        }

    }
}
